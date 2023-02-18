/*
               File: OrdenProduccion
        Description: Orden Produccion
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/17/2023 0:12:2.38
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
   public class ordenproduccion : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vUSUCOD") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLVvUSUCOD0H16( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ORDENPROCESO") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAORDENPROCESO0H16( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ORDENEMPFAC") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAORDENEMPFAC0H16( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ORDENMARCAID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAORDENMARCAID0H16( AV10EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"ORDENMODELOID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            AV22MarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAORDENMODELOID0H16( AV10EmpID, AV22MarcaID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CLIENTEID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLACLIENTEID0H16( AV10EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"VENDEDORID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAVENDEDORID0H16( AV10EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPORDID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLATIPORDID0H16( AV10EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"PROTID") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAPROTID0H16( AV10EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"OBREID") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLAOBREID0H52( ) ;
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
            GXDLADETTIPOPRODID0H17( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"CATEGID") == 0 )
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
            GXDLACATEGID0H17( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel18"+"_"+"ORDENID") == 0 )
         {
            AV26OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrdenID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV26OrdenID), "ZZZ9"), context));
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            AV25OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX18ASAORDENID0H16( AV26OrdenID, AV10EmpID, AV25OrdenAnio) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel32"+"_"+"vVALUENRO") == 0 )
         {
            AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            AV25OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX32ASAVALUENRO0H16( AV10EmpID, AV25OrdenAnio) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_72") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_72( A1EmpID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_74") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A26OrdenMarcaID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_74( A1EmpID, A26OrdenMarcaID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_75") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A8VehiculoID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_75( A1EmpID, A8VehiculoID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_76") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A9vendedorID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_76( A1EmpID, A9vendedorID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_77") == 0 )
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
            gxLoad_77( A1EmpID, A10protID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_78") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A17tipOrdID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_78( A1EmpID, A17tipOrdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_73") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_73( A1EmpID, A5ClienteID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_80") == 0 )
         {
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A24OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            A25OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_80( A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_83") == 0 )
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
            gxLoad_83( A1EmpID, A36detTipoProdID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_84") == 0 )
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
            gxLoad_84( A1EmpID, A32categID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_85") == 0 )
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
            gxLoad_85( A1EmpID, A32categID, A33subCatID) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Griditemsop") == 0 )
         {
            nRC_GXsfl_216 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_216_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_216_idx = GetNextPar( );
            chkOrdenDetDesp.Enabled = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkOrdenDetDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkOrdenDetDesp.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
            A210OrdenUltSec = (short)(NumberUtil.Val( GetNextPar( ), "."));
            n210OrdenUltSec = false;
            Gx_BScreen = (short)(NumberUtil.Val( GetNextPar( ), "."));
            A1EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGriditemsop_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_261 = (short)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_261_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_261_idx = GetNextPar( );
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
               AV10EmpID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
               AV7ageID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ageID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
               AV9ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ClienteID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ClienteID), "ZZZ9"), context));
               AV27OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27OrdenPeriodo), 2, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV27OrdenPeriodo), "Z9"), context));
               AV25OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
               AV26OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrdenID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV26OrdenID), "ZZZ9"), context));
               AV33usuCod = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33usuCod", AV33usuCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
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
            Form.Meta.addItem("description", "Orden Produccion", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtOrdenFch_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public ordenproduccion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public ordenproduccion( IGxContext context )
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
                           short aP2_ageID ,
                           short aP3_ClienteID ,
                           short aP4_OrdenPeriodo ,
                           short aP5_OrdenAnio ,
                           short aP6_OrdenID ,
                           String aP7_usuCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10EmpID = aP1_EmpID;
         this.AV7ageID = aP2_ageID;
         this.AV9ClienteID = aP3_ClienteID;
         this.AV27OrdenPeriodo = aP4_OrdenPeriodo;
         this.AV25OrdenAnio = aP5_OrdenAnio;
         this.AV26OrdenID = aP6_OrdenID;
         this.AV33usuCod = aP7_usuCod;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavUsucod = new GXCombobox();
         cmbOrdenPeriodo = new GXCombobox();
         dynOrdenProceso = new GXCombobox();
         chkavFacemp = new GXCheckbox();
         dynOrdenEmpFac = new GXCombobox();
         dynOrdenMarcaID = new GXCombobox();
         dynOrdenModeloID = new GXCombobox();
         dynClienteID = new GXCombobox();
         dynvendedorID = new GXCombobox();
         dyntipOrdID = new GXCombobox();
         dynprotID = new GXCombobox();
         cmbOrdenEst = new GXCombobox();
         dyndetTipoProdID = new GXCombobox();
         dyncategID = new GXCombobox();
         chkOrdenDetDesp = new GXCheckbox();
         dynObreID = new GXCombobox();
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
         if ( dynavUsucod.ItemCount > 0 )
         {
            AV33usuCod = dynavUsucod.getValidValue(AV33usuCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33usuCod", AV33usuCod);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavUsucod.CurrentValue = StringUtil.RTrim( AV33usuCod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavUsucod_Internalname, "Values", dynavUsucod.ToJavascriptSource(), true);
         }
         if ( cmbOrdenPeriodo.ItemCount > 0 )
         {
            A24OrdenPeriodo = (short)(NumberUtil.Val( cmbOrdenPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbOrdenPeriodo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Values", cmbOrdenPeriodo.ToJavascriptSource(), true);
         }
         if ( dynOrdenProceso.ItemCount > 0 )
         {
            A133OrdenProceso = dynOrdenProceso.getValidValue(A133OrdenProceso);
            n133OrdenProceso = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynOrdenProceso.CurrentValue = StringUtil.RTrim( A133OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Values", dynOrdenProceso.ToJavascriptSource(), true);
         }
         if ( dynOrdenEmpFac.ItemCount > 0 )
         {
            A132OrdenEmpFac = (short)(NumberUtil.Val( dynOrdenEmpFac.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0))), "."));
            n132OrdenEmpFac = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynOrdenEmpFac.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenEmpFac_Internalname, "Values", dynOrdenEmpFac.ToJavascriptSource(), true);
         }
         if ( dynOrdenMarcaID.ItemCount > 0 )
         {
            A26OrdenMarcaID = (short)(NumberUtil.Val( dynOrdenMarcaID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynOrdenMarcaID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenMarcaID_Internalname, "Values", dynOrdenMarcaID.ToJavascriptSource(), true);
         }
         if ( dynOrdenModeloID.ItemCount > 0 )
         {
            A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117OrdenModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenModeloID_Internalname, "Values", dynOrdenModeloID.ToJavascriptSource(), true);
         }
         if ( dynClienteID.ItemCount > 0 )
         {
            A5ClienteID = (short)(NumberUtil.Val( dynClienteID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Values", dynClienteID.ToJavascriptSource(), true);
         }
         if ( dynvendedorID.ItemCount > 0 )
         {
            A9vendedorID = (short)(NumberUtil.Val( dynvendedorID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynvendedorID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynvendedorID_Internalname, "Values", dynvendedorID.ToJavascriptSource(), true);
         }
         if ( dyntipOrdID.ItemCount > 0 )
         {
            A17tipOrdID = (short)(NumberUtil.Val( dyntipOrdID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dyntipOrdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyntipOrdID_Internalname, "Values", dyntipOrdID.ToJavascriptSource(), true);
         }
         if ( dynprotID.ItemCount > 0 )
         {
            A10protID = (short)(NumberUtil.Val( dynprotID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Values", dynprotID.ToJavascriptSource(), true);
         }
         if ( cmbOrdenEst.ItemCount > 0 )
         {
            A115OrdenEst = cmbOrdenEst.getValidValue(A115OrdenEst);
            n115OrdenEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbOrdenEst.CurrentValue = StringUtil.RTrim( A115OrdenEst);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenEst_Internalname, "Values", cmbOrdenEst.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-3", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Orden Produccion", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-9", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2 col-lg-12 col-lg-offset-0", "left", "Middle", "", "", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Seleccionar", bttBtn_select_Jsonclick, 4, "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00g0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ORDENPERIODO"+"'), id:'"+"ORDENPERIODO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ORDENANIO"+"'), id:'"+"ORDENANIO"+"'"+",IOType:'out'}"+","+"{Ctrl:gx.dom.el('"+"ORDENID"+"'), id:'"+"ORDENID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenFch_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenFch_Internalname, "Registro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtOrdenFch_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOrdenFch_Internalname, context.localUtil.Format(A119OrdenFch, "99/99/9999"), context.localUtil.Format( A119OrdenFch, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenFch_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenFch_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_bitmap( context, edtOrdenFch_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtOrdenFch_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenProduccion.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavUsucod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavUsucod_Internalname, "User", "col-sm-3 col-lg-2 AttributeBoldLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-lg-10 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavUsucod, dynavUsucod_Internalname, StringUtil.RTrim( AV33usuCod), 1, dynavUsucod_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, dynavUsucod.Enabled, 0, 0, 0, "em", 0, "", "", "AttributeBold", "", "", "", "", true, "HLP_OrdenProduccion.htm");
            dynavUsucod.CurrentValue = StringUtil.RTrim( AV33usuCod);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavUsucod_Internalname, "Values", (String)(dynavUsucod.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-lg-4 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtOrdenfchEnt_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenfchEnt_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenfchEnt_Internalname, "Entregado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtOrdenfchEnt_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtOrdenfchEnt_Internalname, context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"), context.localUtil.Format( A172OrdenfchEnt, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenfchEnt_Jsonclick, 0, "Attribute", "", "", "", "", edtOrdenfchEnt_Visible, edtOrdenfchEnt_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_bitmap( context, edtOrdenfchEnt_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtOrdenfchEnt_Visible==0)||(edtOrdenfchEnt_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenProduccion.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-2", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection3_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenAnio_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenAnio_Internalname, "Año", " AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenAnio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A25OrdenAnio), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A25OrdenAnio), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenAnio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenAnio_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-5", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection2_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbOrdenPeriodo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbOrdenPeriodo_Internalname, "Mes", " ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbOrdenPeriodo, cmbOrdenPeriodo_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)), 1, cmbOrdenPeriodo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbOrdenPeriodo.Enabled, 1, 0, 150, "px", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", true, "HLP_OrdenProduccion.htm");
            cmbOrdenPeriodo.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Values", (String)(cmbOrdenPeriodo.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-lg-5", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSection1_Internalname, 1, 0, "px", 0, "px", "FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynOrdenProceso_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynOrdenProceso_Internalname, "Proceso Act.", " ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynOrdenProceso, dynOrdenProceso_Internalname, StringUtil.RTrim( A133OrdenProceso), 1, dynOrdenProceso_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"EORDENPROCESO.CLICK."+"'", "svchar", "", 1, dynOrdenProceso.Enabled, 0, 0, 20, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "", true, "HLP_OrdenProduccion.htm");
            dynOrdenProceso.CurrentValue = StringUtil.RTrim( A133OrdenProceso);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Values", (String)(dynOrdenProceso.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmpID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1EmpID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A1EmpID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmpID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmpID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProduccion.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_1_Internalname, sImgUrl, imgprompt_1_Link, "", "", context.GetTheme( ), imgprompt_1_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
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
            GxWebStd.gx_single_line_edit( context, edtempdsc_Internalname, A44empdsc, StringUtil.RTrim( context.localUtil.Format( A44empdsc, "@!")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtempdsc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtempdsc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavFacemp_Internalname, "fac Emp", "col-sm-3 AttributeLabel", 0, true);
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavFacemp_Internalname, StringUtil.Str( (decimal)(AV11facEmp), 4, 0), "", "fac Emp", 1, chkavFacemp.Enabled, "   1", "Misma empresa", StyleString, ClassString, "", "", TempTags);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbempfac_Internalname, divTbempfac_Visible, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynOrdenEmpFac_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynOrdenEmpFac_Internalname, "Empresa Facturar", "col-sm-3 ComboAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynOrdenEmpFac, dynOrdenEmpFac_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)), 1, dynOrdenEmpFac_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynOrdenEmpFac.Enabled, 0, 0, 14, "em", 0, "", "", "ComboAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "", true, "HLP_OrdenProduccion.htm");
            dynOrdenEmpFac.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenEmpFac_Internalname, "Values", (String)(dynOrdenEmpFac.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynOrdenMarcaID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynOrdenMarcaID_Internalname, "Marca", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynOrdenMarcaID, dynOrdenMarcaID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)), 1, dynOrdenMarcaID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynOrdenMarcaID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "", true, "HLP_OrdenProduccion.htm");
            dynOrdenMarcaID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenMarcaID_Internalname, "Values", (String)(dynOrdenMarcaID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_26_Internalname, sImgUrl, imgprompt_26_Link, "", "", context.GetTheme( ), imgprompt_26_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynOrdenModeloID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynOrdenModeloID_Internalname, "Modelo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynOrdenModeloID, dynOrdenModeloID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)), 1, dynOrdenModeloID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynOrdenModeloID.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "", true, "HLP_OrdenProduccion.htm");
            dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenModeloID_Internalname, "Values", (String)(dynOrdenModeloID.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynClienteID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynClienteID_Internalname, "Cliente", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynClienteID, dynClienteID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)), 1, dynClienteID_Jsonclick, 5, "'"+""+"'"+",false,"+"'"+"ECLIENTEID.CLICK."+"'", "int", "", 1, dynClienteID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "", true, "HLP_OrdenProduccion.htm");
            dynClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Values", (String)(dynClienteID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_5_Internalname, sImgUrl, imgprompt_5_Link, "", "", context.GetTheme( ), imgprompt_5_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTbnomfac_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtOrdenFacNomb_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenFacNomb_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenFacNomb_Internalname, "Facturar a", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenFacNomb_Internalname, StringUtil.RTrim( A195OrdenFacNomb), StringUtil.RTrim( context.localUtil.Format( A195OrdenFacNomb, "@!")), TempTags+" onchange=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenFacNomb_Jsonclick, 0, "Attribute", "", "", "", "", edtOrdenFacNomb_Visible, edtOrdenFacNomb_Enabled, 0, "text", "", 430, "px", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "nombres", "left", true, "HLP_OrdenProduccion.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynvendedorID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynvendedorID_Internalname, "Vendedor", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynvendedorID, dynvendedorID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)), 1, dynvendedorID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynvendedorID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,119);\"", "", true, "HLP_OrdenProduccion.htm");
            dynvendedorID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynvendedorID_Internalname, "Values", (String)(dynvendedorID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_9_Internalname, sImgUrl, imgprompt_9_Link, "", "", context.GetTheme( ), imgprompt_9_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
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
            GxWebStd.gx_label_element( context, edtOrdenID_Internalname, "Secuencia Nro.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A22OrdenID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,124);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dyntipOrdID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dyntipOrdID_Internalname, "Tipo Orden", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dyntipOrdID, dyntipOrdID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)), 1, dyntipOrdID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dyntipOrdID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,129);\"", "", true, "HLP_OrdenProduccion.htm");
            dyntipOrdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyntipOrdID_Internalname, "Values", (String)(dyntipOrdID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_17_Internalname, sImgUrl, imgprompt_17_Link, "", "", context.GetTheme( ), imgprompt_17_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynprotID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynprotID_Internalname, "Prototipo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynprotID, dynprotID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0)), 1, dynprotID_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, dynprotID.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,134);\"", "", true, "HLP_OrdenProduccion.htm");
            dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Values", (String)(dynprotID.ToJavascriptSource()), true);
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_10_Internalname, sImgUrl, imgprompt_10_Link, "", "", context.GetTheme( ), imgprompt_10_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtfacturaNro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtfacturaNro_Internalname, "Factura Nro.", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtfacturaNro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A106facturaNro), 8, 0, ",", "")), ((edtfacturaNro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9")) : context.localUtil.Format( (decimal)(A106facturaNro), "ZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,139);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtfacturaNro_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtfacturaNro_Enabled, 0, "number", "1", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtrepresentane_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtrepresentane_Internalname, "representane", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtrepresentane_Internalname, StringUtil.RTrim( A107representane), StringUtil.RTrim( context.localUtil.Format( A107representane, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtrepresentane_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtrepresentane_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "Descripcion", "left", true, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoID_Internalname, "Vehiculo ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVehiculoID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ",", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A8VehiculoID), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,149);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoID_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "HLP_OrdenProduccion.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_8_Internalname, sImgUrl, imgprompt_8_Link, "", "", context.GetTheme( ), imgprompt_8_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoPlaca_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoPlaca_Internalname, "# Placa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVehiculoPlaca_Internalname, A68VehiculoPlaca, StringUtil.RTrim( context.localUtil.Format( A68VehiculoPlaca, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoPlaca_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoPlaca_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtVehiculoChasis_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtVehiculoChasis_Internalname, "# Chasis", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtVehiculoChasis_Internalname, A69VehiculoChasis, StringUtil.RTrim( context.localUtil.Format( A69VehiculoChasis, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVehiculoChasis_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtVehiculoChasis_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenPdf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenPdf_Internalname, "Archivo PDF", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 164,'',false,'',0)\"";
            edtOrdenPdf_Filetype = ".pdf";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "Filetype", edtOrdenPdf_Filetype, true);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) )
            {
               gxblobfileaux.Source = A152OrdenPdf;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtOrdenPdf_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtOrdenPdf_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A152OrdenPdf = gxblobfileaux.GetURI();
                  n152OrdenPdf = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152OrdenPdf", A152OrdenPdf);
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), true);
                  edtOrdenPdf_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "Filetype", edtOrdenPdf_Filetype, true);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), true);
            }
            GxWebStd.gx_blob_field( context, edtOrdenPdf_Internalname, StringUtil.RTrim( A152OrdenPdf), context.PathToRelativeUrl( A152OrdenPdf), (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenPdf_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenPdf_Filetype)) ? A152OrdenPdf : edtOrdenPdf_Filetype)) : edtOrdenPdf_Contenttype), false, "", edtOrdenPdf_Parameters, 1, edtOrdenPdf_Enabled, 1, "", "", 0, 0, 500, "px", 60, "px", 0, 0, 0, edtOrdenPdf_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", StyleString, ClassString, "", "", ""+TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,164);\"", "", "", "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtfchVenta_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtfchVenta_Internalname, "Venta", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 169,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtfchVenta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtfchVenta_Internalname, context.localUtil.Format(A109fchVenta, "99/99/9999"), context.localUtil.Format( A109fchVenta, "99/99/9999"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,169);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtfchVenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtfchVenta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_bitmap( context, edtfchVenta_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtfchVenta_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_OrdenProduccion.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtcantDias_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtcantDias_Internalname, "Dias", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 174,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtcantDias_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A110cantDias), 4, 0, ",", "")), ((edtcantDias_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A110cantDias), "ZZZ9")) : context.localUtil.Format( (decimal)(A110cantDias), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,174);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtcantDias_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtcantDias_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenActaPdf_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenActaPdf_Internalname, "Acta Recepcion", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 179,'',false,'',0)\"";
            edtOrdenActaPdf_Filetype = ".pdf";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "Filetype", edtOrdenActaPdf_Filetype, true);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) )
            {
               gxblobfileaux.Source = A153OrdenActaPdf;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtOrdenActaPdf_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtOrdenActaPdf_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A153OrdenActaPdf = gxblobfileaux.GetURI();
                  n153OrdenActaPdf = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153OrdenActaPdf", A153OrdenActaPdf);
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), true);
                  edtOrdenActaPdf_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "Filetype", edtOrdenActaPdf_Filetype, true);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), true);
            }
            GxWebStd.gx_blob_field( context, edtOrdenActaPdf_Internalname, StringUtil.RTrim( A153OrdenActaPdf), context.PathToRelativeUrl( A153OrdenActaPdf), (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenActaPdf_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtOrdenActaPdf_Filetype)) ? A153OrdenActaPdf : edtOrdenActaPdf_Filetype)) : edtOrdenActaPdf_Contenttype), false, "", edtOrdenActaPdf_Parameters, 1, edtOrdenActaPdf_Enabled, 1, "", "", 0, 0, 500, "px", 60, "px", 0, 0, 0, edtOrdenActaPdf_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", StyleString, ClassString, "", "", ""+TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,179);\"", "", "", "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenSubtotal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenSubtotal_Internalname, "Subtotal", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 184,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenSubtotal_Internalname, StringUtil.LTrim( StringUtil.NToC( A161OrdenSubtotal, 10, 3, ",", "")), ((edtOrdenSubtotal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A161OrdenSubtotal, "ZZZZZ9.999")) : context.localUtil.Format( A161OrdenSubtotal, "ZZZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,184);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenSubtotal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenSubtotal_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbOrdenEst_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbOrdenEst_Internalname, "estado", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 189,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbOrdenEst, cmbOrdenEst_Internalname, StringUtil.RTrim( A115OrdenEst), 1, cmbOrdenEst_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "char", "", 1, cmbOrdenEst.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,189);\"", "", true, "HLP_OrdenProduccion.htm");
            cmbOrdenEst.CurrentValue = StringUtil.RTrim( A115OrdenEst);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenEst_Internalname, "Values", (String)(cmbOrdenEst.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenNroDesp_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenNroDesp_Internalname, "Nro. Despacho", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 194,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenNroDesp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A401OrdenNroDesp), 6, 0, ",", "")), ((edtOrdenNroDesp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A401OrdenNroDesp), "ZZZZZ9")) : context.localUtil.Format( (decimal)(A401OrdenNroDesp), "ZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,194);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenNroDesp_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenNroDesp_Enabled, 0, "number", "1", 6, "chr", 1, "row", 6, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "Middle", "", "", "div");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"TABCOSTEOContainer"+"\"></div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblItems_title_Internalname, "Pedidos", "", "", lblItems_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_OrdenProduccion.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Items") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table3_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavErrormesjtool_Internalname, "error Mesj Tool", " ErrorAttributeBoldLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 207,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavErrormesjtool_Internalname, AV40errorMesjTool, StringUtil.RTrim( context.localUtil.Format( AV40errorMesjTool, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,207);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavErrormesjtool_Jsonclick, 0, "ErrorAttributeBold", "", "", "", "", 1, edtavErrormesjtool_Enabled, 1, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 211,'',false,'',0)\"";
            ClassString = "BtnPdf";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "Visualizar", bttButton3_Jsonclick, 5, "Visualizar", "", StyleString, ClassString, bttButton3_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'EXPORTPDF\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 213,'',false,'',0)\"";
            ClassString = "BtnExportXls";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Exportar xls", bttButton1_Jsonclick, 5, "Exportar excel", "", StyleString, ClassString, bttButton1_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'EXEXCEL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            gxdraw_Griditemsop( ) ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCosteomatprim_title_Internalname, "Materia Prima", "", "", lblCosteomatprim_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_OrdenProduccion.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CosteoMatPrim") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "Middle", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenValInds_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenValInds_Internalname, "Valor Industria", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 238,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenValInds_Internalname, StringUtil.LTrim( StringUtil.NToC( A162OrdenValInds, 10, 3, ",", "")), ((edtOrdenValInds_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A162OrdenValInds, "ZZZZZ9.999")) : context.localUtil.Format( A162OrdenValInds, "ZZZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,238);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenValInds_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenValInds_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenValEnrq_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenValEnrq_Internalname, "Valor Enrique", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 243,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenValEnrq_Internalname, StringUtil.LTrim( StringUtil.NToC( A163OrdenValEnrq, 10, 3, ",", "")), ((edtOrdenValEnrq_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A163OrdenValEnrq, "ZZZZZ9.999")) : context.localUtil.Format( A163OrdenValEnrq, "ZZZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,243);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenValEnrq_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenValEnrq_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenValCal_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenValCal_Internalname, "Valor Calphesa", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 248,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrdenValCal_Internalname, StringUtil.LTrim( StringUtil.NToC( A165OrdenValCal, 10, 3, ",", "")), ((edtOrdenValCal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A165OrdenValCal, "ZZZZZ9.999")) : context.localUtil.Format( A165OrdenValCal, "ZZZZZ9.999")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','3');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,248);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenValCal_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenValCal_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenValMatPri_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenValMatPri_Internalname, "Total Materia Prima", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOrdenValMatPri_Internalname, StringUtil.LTrim( StringUtil.NToC( A164OrdenValMatPri, 10, 3, ",", "")), ((edtOrdenValMatPri_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A164OrdenValMatPri, "ZZZZZ9.999")) : context.localUtil.Format( A164OrdenValMatPri, "ZZZZZ9.999")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenValMatPri_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenValMatPri_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblManoobra_title_Internalname, "Mano Obra", "", "", lblManoobra_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_OrdenProduccion.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "ManoObra") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table1_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-lg-9 FormCell", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenObreSuma_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenObreSuma_Internalname, "Total Mano Obra", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOrdenObreSuma_Internalname, StringUtil.LTrim( StringUtil.NToC( A255OrdenObreSuma, 10, 2, ",", "")), ((edtOrdenObreSuma_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A255OrdenObreSuma, "ZZZZZZ9.99")) : context.localUtil.Format( A255OrdenObreSuma, "ZZZZZZ9.99")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenObreSuma_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenObreSuma_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTotalrenta_title_Internalname, "Total", "", "", lblTotalrenta_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_OrdenProduccion.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "TotalRenta") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABCOSTEOContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabpage1table2_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenTotGast_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenTotGast_Internalname, "Total Gastos", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOrdenTotGast_Internalname, StringUtil.LTrim( StringUtil.NToC( A170OrdenTotGast, 10, 3, ",", "")), ((edtOrdenTotGast_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A170OrdenTotGast, "ZZZZZ9.999")) : context.localUtil.Format( A170OrdenTotGast, "ZZZZZ9.999")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenTotGast_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenTotGast_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrdenValRenta_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrdenValRenta_Internalname, "Valor Rentabilidad", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtOrdenValRenta_Internalname, StringUtil.LTrim( StringUtil.NToC( A171OrdenValRenta, 10, 3, ",", "")), ((edtOrdenValRenta_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A171OrdenValRenta, "ZZZZZ9.999")) : context.localUtil.Format( A171OrdenValRenta, "ZZZZZ9.999")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrdenValRenta_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrdenValRenta_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "Middle", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavMarcaid_Internalname, "Marca ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavMarcaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22MarcaID), 4, 0, ",", "")), ((edtavMarcaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22MarcaID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV22MarcaID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMarcaid_Jsonclick, 0, "Attribute", "", "", "", "", edtavMarcaid_Visible, edtavMarcaid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEmpid_Internalname, "Emp ID", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavEmpid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10EmpID), 4, 0, ",", "")), ((edtavEmpid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEmpid_Jsonclick, 0, "Attribute", "", "", "", "", edtavEmpid_Visible, edtavEmpid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavValuenro_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavValuenro_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavValuenro_Internalname, "nro", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavValuenro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34valueNro), 4, 0, ",", "")), ((edtavValuenro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV34valueNro), "ZZZ9")) : context.localUtil.Format( (decimal)(AV34valueNro), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavValuenro_Jsonclick, 0, "Attribute", "", "", "", "", edtavValuenro_Visible, edtavValuenro_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_OrdenProduccion.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 302,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter2_Internalname, "", "Confirmar", bttBtnenter2_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtnenter2_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 304,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Cancelar", bttButton2_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttButton2_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_OrdenProduccion.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
            RenderHtmlCloseForm0H16( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void gxdraw_Griditemsop( )
      {
         /*  Grid Control  */
         GriditemsopContainer.AddObjectProperty("GridName", "Griditemsop");
         GriditemsopContainer.AddObjectProperty("Header", subGriditemsop_Header);
         GriditemsopContainer.AddObjectProperty("Class", "Grid");
         GriditemsopContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Backcolorstyle), 1, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Sortable), 1, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("CmpContext", "");
         GriditemsopContainer.AddObjectProperty("InMasterPage", "false");
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A41OrdenSecId), 4, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenSecId_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyndetTipoProdID.Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyncategID.Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.RTrim( A146categDsc));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.RTrim( A148subCatDsc));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A396OrdenDetDesp), 1, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkOrdenDetDesp.Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A208OrdenDetCant, 8, 2, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetCant_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A209OrdenDetVal, 8, 2, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetVal_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", A251OrdenDetDetalle);
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         GriditemsopColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A397OrdenDesp), 2, 0, ".", "")));
         GriditemsopColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDesp_Enabled), 5, 0, ".", "")));
         GriditemsopContainer.AddColumnProperties(GriditemsopColumn);
         GriditemsopContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Selectedindex), 4, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Allowselection), 1, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Selectioncolor), 9, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Allowhovering), 1, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Hoveringcolor), 9, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Allowcollapsing), 1, 0, ".", "")));
         GriditemsopContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGriditemsop_Collapsed), 1, 0, ".", "")));
         nGXsfl_216_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount17 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_17 = 1;
               ScanStart0H17( ) ;
               while ( RcdFound17 != 0 )
               {
                  init_level_properties17( ) ;
                  getByPrimaryKey0H17( ) ;
                  AddRow0H17( ) ;
                  ScanNext0H17( ) ;
               }
               ScanEnd0H17( ) ;
               nBlankRcdCount17 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B210OrdenUltSec = A210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            standaloneNotModal0H17( ) ;
            standaloneModal0H17( ) ;
            sMode17 = Gx_mode;
            while ( nGXsfl_216_idx < nRC_GXsfl_216 )
            {
               bGXsfl_216_Refreshing = true;
               ReadRow0H17( ) ;
               edtOrdenSecId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENSECID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenSecId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenSecId_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               dyndetTipoProdID.Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               dyncategID.Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtcategDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGDSC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               chkOrdenDetDesp.Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETDESP_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkOrdenDetDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkOrdenDetDesp.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtOrdenDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETCANT_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetCant_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtOrdenDetVal_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETVAL_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetVal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetVal_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtOrdenDetDetalle_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETDETALLE_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               edtOrdenDesp_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDESP_"+sGXsfl_216_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDesp_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
               imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_216_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_216_idx+"Link");
               imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_216_idx+"Link");
               if ( ( nRcdExists_17 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0H17( ) ;
               }
               SendRow0H17( ) ;
               bGXsfl_216_Refreshing = false;
            }
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A210OrdenUltSec = B210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount17 = 5;
            nRcdExists_17 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0H17( ) ;
               while ( RcdFound17 != 0 )
               {
                  sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_21617( ) ;
                  init_level_properties17( ) ;
                  standaloneNotModal0H17( ) ;
                  getByPrimaryKey0H17( ) ;
                  standaloneModal0H17( ) ;
                  AddRow0H17( ) ;
                  ScanNext0H17( ) ;
               }
               ScanEnd0H17( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode17 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_21617( ) ;
            InitAll0H17( ) ;
            init_level_properties17( ) ;
            B210OrdenUltSec = A210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            standaloneNotModal0H17( ) ;
            standaloneModal0H17( ) ;
            nRcdExists_17 = 0;
            nIsMod_17 = 0;
            nRcdDeleted_17 = 0;
            nBlankRcdCount17 = (short)(nBlankRcdUsr17+nBlankRcdCount17);
            fRowAdded = 0;
            while ( nBlankRcdCount17 > 0 )
            {
               AddRow0H17( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = dyndetTipoProdID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount17 = (short)(nBlankRcdCount17-1);
            }
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A210OrdenUltSec = B210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"GriditemsopContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Griditemsop", GriditemsopContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "GriditemsopContainerData", GriditemsopContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "GriditemsopContainerData"+"V", GriditemsopContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GriditemsopContainerData"+"V"+"\" value='"+GriditemsopContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void gxdraw_Grid1( )
      {
         /*  Grid Control  */
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("Header", subGrid1_Header);
         Grid1Container.AddObjectProperty("Class", "GridManoObra");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A252OrdenObrID), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObrID_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynObreID.Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", A253OrdenObreManObra);
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreManObra_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A254OrdenObreValor, 10, 2, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreValor_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         nGXsfl_261_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount52 = 5;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               /* Display confirmed (stored) records */
               nRcdExists_52 = 1;
               ScanStart0H52( ) ;
               while ( RcdFound52 != 0 )
               {
                  init_level_properties52( ) ;
                  getByPrimaryKey0H52( ) ;
                  AddRow0H52( ) ;
                  ScanNext0H52( ) ;
               }
               ScanEnd0H52( ) ;
               nBlankRcdCount52 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            B210OrdenUltSec = A210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            standaloneNotModal0H52( ) ;
            standaloneModal0H52( ) ;
            sMode52 = Gx_mode;
            while ( nGXsfl_261_idx < nRC_GXsfl_261 )
            {
               bGXsfl_261_Refreshing = true;
               ReadRow0H52( ) ;
               edtOrdenObrID_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBRID_"+sGXsfl_261_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObrID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObrID_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
               dynObreID.Enabled = (int)(context.localUtil.CToN( cgiGet( "OBREID_"+sGXsfl_261_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynObreID.Enabled), 5, 0)), !bGXsfl_261_Refreshing);
               edtOrdenObreManObra_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBREMANOBRA_"+sGXsfl_261_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObreManObra_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObreManObra_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
               edtOrdenObreValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBREVALOR_"+sGXsfl_261_idx+"Enabled"), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObreValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObreValor_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
               if ( ( nRcdExists_52 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0H52( ) ;
               }
               SendRow0H52( ) ;
               bGXsfl_261_Refreshing = false;
            }
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A210OrdenUltSec = B210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount52 = 5;
            nRcdExists_52 = 1;
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               ScanStart0H52( ) ;
               while ( RcdFound52 != 0 )
               {
                  sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx+1), 4, 0)), 4, "0");
                  SubsflControlProps_26152( ) ;
                  init_level_properties52( ) ;
                  standaloneNotModal0H52( ) ;
                  getByPrimaryKey0H52( ) ;
                  standaloneModal0H52( ) ;
                  AddRow0H52( ) ;
                  ScanNext0H52( ) ;
               }
               ScanEnd0H52( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
         {
            sMode52 = Gx_mode;
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx+1), 4, 0)), 4, "0");
            SubsflControlProps_26152( ) ;
            InitAll0H52( ) ;
            init_level_properties52( ) ;
            B210OrdenUltSec = A210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            standaloneNotModal0H52( ) ;
            standaloneModal0H52( ) ;
            nRcdExists_52 = 0;
            nIsMod_52 = 0;
            nRcdDeleted_52 = 0;
            nBlankRcdCount52 = (short)(nBlankRcdUsr52+nBlankRcdCount52);
            fRowAdded = 0;
            while ( nBlankRcdCount52 > 0 )
            {
               AddRow0H52( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtOrdenObrID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount52 = (short)(nBlankRcdCount52-1);
            }
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            A210OrdenUltSec = B210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
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
         E110H2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( context.localUtil.VCDate( cgiGet( edtOrdenFch_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Orden Fch"}), 1, "ORDENFCH");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A119OrdenFch = DateTime.MinValue;
                  n119OrdenFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               }
               else
               {
                  A119OrdenFch = context.localUtil.CToD( cgiGet( edtOrdenFch_Internalname), 2);
                  n119OrdenFch = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
               }
               n119OrdenFch = ((DateTime.MinValue==A119OrdenFch) ? true : false);
               dynavUsucod.Name = dynavUsucod_Internalname;
               dynavUsucod.CurrentValue = cgiGet( dynavUsucod_Internalname);
               AV33usuCod = cgiGet( dynavUsucod_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33usuCod", AV33usuCod);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
               if ( context.localUtil.VCDate( cgiGet( edtOrdenfchEnt_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Entrega"}), 1, "ORDENFCHENT");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenfchEnt_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A172OrdenfchEnt = DateTime.MinValue;
                  n172OrdenfchEnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
               }
               else
               {
                  A172OrdenfchEnt = context.localUtil.CToD( cgiGet( edtOrdenfchEnt_Internalname), 2);
                  n172OrdenfchEnt = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
               }
               n172OrdenfchEnt = ((DateTime.MinValue==A172OrdenfchEnt) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENANIO");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenAnio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A25OrdenAnio = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
               }
               else
               {
                  A25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( edtOrdenAnio_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
               }
               cmbOrdenPeriodo.Name = cmbOrdenPeriodo_Internalname;
               cmbOrdenPeriodo.CurrentValue = cgiGet( cmbOrdenPeriodo_Internalname);
               A24OrdenPeriodo = (short)(NumberUtil.Val( cgiGet( cmbOrdenPeriodo_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
               dynOrdenProceso.Name = dynOrdenProceso_Internalname;
               dynOrdenProceso.CurrentValue = cgiGet( dynOrdenProceso_Internalname);
               A133OrdenProceso = cgiGet( dynOrdenProceso_Internalname);
               n133OrdenProceso = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
               n133OrdenProceso = (String.IsNullOrEmpty(StringUtil.RTrim( A133OrdenProceso)) ? true : false);
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
               AV11facEmp = (short)(((StringUtil.StrCmp(cgiGet( chkavFacemp_Internalname), "1")==0) ? 1 : 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
               dynOrdenEmpFac.Name = dynOrdenEmpFac_Internalname;
               dynOrdenEmpFac.CurrentValue = cgiGet( dynOrdenEmpFac_Internalname);
               A132OrdenEmpFac = (short)(NumberUtil.Val( cgiGet( dynOrdenEmpFac_Internalname), "."));
               n132OrdenEmpFac = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
               n132OrdenEmpFac = ((0==A132OrdenEmpFac) ? true : false);
               dynOrdenMarcaID.Name = dynOrdenMarcaID_Internalname;
               dynOrdenMarcaID.CurrentValue = cgiGet( dynOrdenMarcaID_Internalname);
               A26OrdenMarcaID = (short)(NumberUtil.Val( cgiGet( dynOrdenMarcaID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
               dynOrdenModeloID.Name = dynOrdenModeloID_Internalname;
               dynOrdenModeloID.CurrentValue = cgiGet( dynOrdenModeloID_Internalname);
               A117OrdenModeloID = (short)(NumberUtil.Val( cgiGet( dynOrdenModeloID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117OrdenModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)));
               dynClienteID.Name = dynClienteID_Internalname;
               dynClienteID.CurrentValue = cgiGet( dynClienteID_Internalname);
               A5ClienteID = (short)(NumberUtil.Val( cgiGet( dynClienteID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               A195OrdenFacNomb = StringUtil.Upper( cgiGet( edtOrdenFacNomb_Internalname));
               n195OrdenFacNomb = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195OrdenFacNomb", A195OrdenFacNomb);
               n195OrdenFacNomb = (String.IsNullOrEmpty(StringUtil.RTrim( A195OrdenFacNomb)) ? true : false);
               dynvendedorID.Name = dynvendedorID_Internalname;
               dynvendedorID.CurrentValue = cgiGet( dynvendedorID_Internalname);
               A9vendedorID = (short)(NumberUtil.Val( cgiGet( dynvendedorID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
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
               dyntipOrdID.Name = dyntipOrdID_Internalname;
               dyntipOrdID.CurrentValue = cgiGet( dyntipOrdID_Internalname);
               A17tipOrdID = (short)(NumberUtil.Val( cgiGet( dyntipOrdID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
               dynprotID.Name = dynprotID_Internalname;
               dynprotID.CurrentValue = cgiGet( dynprotID_Internalname);
               A10protID = (short)(NumberUtil.Val( cgiGet( dynprotID_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "FACTURANRO");
                  AnyError = 1;
                  GX_FocusControl = edtfacturaNro_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A106facturaNro = 0;
                  n106facturaNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106facturaNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A106facturaNro), 8, 0)));
               }
               else
               {
                  A106facturaNro = (int)(context.localUtil.CToN( cgiGet( edtfacturaNro_Internalname), ",", "."));
                  n106facturaNro = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106facturaNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A106facturaNro), 8, 0)));
               }
               n106facturaNro = ((0==A106facturaNro) ? true : false);
               A107representane = cgiGet( edtrepresentane_Internalname);
               n107representane = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107representane", A107representane);
               n107representane = (String.IsNullOrEmpty(StringUtil.RTrim( A107representane)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEHICULOID");
                  AnyError = 1;
                  GX_FocusControl = edtVehiculoID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8VehiculoID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               }
               else
               {
                  A8VehiculoID = (short)(context.localUtil.CToN( cgiGet( edtVehiculoID_Internalname), ",", "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
               }
               A68VehiculoPlaca = cgiGet( edtVehiculoPlaca_Internalname);
               n68VehiculoPlaca = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
               A69VehiculoChasis = cgiGet( edtVehiculoChasis_Internalname);
               n69VehiculoChasis = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
               A152OrdenPdf = cgiGet( edtOrdenPdf_Internalname);
               n152OrdenPdf = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152OrdenPdf", A152OrdenPdf);
               n152OrdenPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtfchVenta_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha Venta"}), 1, "FCHVENTA");
                  AnyError = 1;
                  GX_FocusControl = edtfchVenta_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A109fchVenta = DateTime.MinValue;
                  n109fchVenta = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109fchVenta", context.localUtil.Format(A109fchVenta, "99/99/9999"));
               }
               else
               {
                  A109fchVenta = context.localUtil.CToD( cgiGet( edtfchVenta_Internalname), 2);
                  n109fchVenta = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109fchVenta", context.localUtil.Format(A109fchVenta, "99/99/9999"));
               }
               n109fchVenta = ((DateTime.MinValue==A109fchVenta) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtcantDias_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtcantDias_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "CANTDIAS");
                  AnyError = 1;
                  GX_FocusControl = edtcantDias_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A110cantDias = 0;
                  n110cantDias = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110cantDias", StringUtil.LTrim( StringUtil.Str( (decimal)(A110cantDias), 4, 0)));
               }
               else
               {
                  A110cantDias = (short)(context.localUtil.CToN( cgiGet( edtcantDias_Internalname), ",", "."));
                  n110cantDias = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110cantDias", StringUtil.LTrim( StringUtil.Str( (decimal)(A110cantDias), 4, 0)));
               }
               n110cantDias = ((0==A110cantDias) ? true : false);
               A153OrdenActaPdf = cgiGet( edtOrdenActaPdf_Internalname);
               n153OrdenActaPdf = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153OrdenActaPdf", A153OrdenActaPdf);
               n153OrdenActaPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenSubtotal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenSubtotal_Internalname), ",", ".") > 999999.999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENSUBTOTAL");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenSubtotal_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A161OrdenSubtotal = 0;
                  n161OrdenSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161OrdenSubtotal", StringUtil.LTrim( StringUtil.Str( A161OrdenSubtotal, 10, 3)));
               }
               else
               {
                  A161OrdenSubtotal = context.localUtil.CToN( cgiGet( edtOrdenSubtotal_Internalname), ",", ".");
                  n161OrdenSubtotal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161OrdenSubtotal", StringUtil.LTrim( StringUtil.Str( A161OrdenSubtotal, 10, 3)));
               }
               n161OrdenSubtotal = ((Convert.ToDecimal(0)==A161OrdenSubtotal) ? true : false);
               cmbOrdenEst.Name = cmbOrdenEst_Internalname;
               cmbOrdenEst.CurrentValue = cgiGet( cmbOrdenEst_Internalname);
               A115OrdenEst = cgiGet( cmbOrdenEst_Internalname);
               n115OrdenEst = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
               n115OrdenEst = (String.IsNullOrEmpty(StringUtil.RTrim( A115OrdenEst)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenNroDesp_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenNroDesp_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENNRODESP");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenNroDesp_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A401OrdenNroDesp = 0;
                  n401OrdenNroDesp = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401OrdenNroDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(A401OrdenNroDesp), 6, 0)));
               }
               else
               {
                  A401OrdenNroDesp = (int)(context.localUtil.CToN( cgiGet( edtOrdenNroDesp_Internalname), ",", "."));
                  n401OrdenNroDesp = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401OrdenNroDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(A401OrdenNroDesp), 6, 0)));
               }
               n401OrdenNroDesp = ((0==A401OrdenNroDesp) ? true : false);
               AV40errorMesjTool = cgiGet( edtavErrormesjtool_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40errorMesjTool", AV40errorMesjTool);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenValInds_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenValInds_Internalname), ",", ".") > 999999.999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENVALINDS");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenValInds_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A162OrdenValInds = 0;
                  n162OrdenValInds = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162OrdenValInds", StringUtil.LTrim( StringUtil.Str( A162OrdenValInds, 10, 3)));
               }
               else
               {
                  A162OrdenValInds = context.localUtil.CToN( cgiGet( edtOrdenValInds_Internalname), ",", ".");
                  n162OrdenValInds = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162OrdenValInds", StringUtil.LTrim( StringUtil.Str( A162OrdenValInds, 10, 3)));
               }
               n162OrdenValInds = ((Convert.ToDecimal(0)==A162OrdenValInds) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenValEnrq_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenValEnrq_Internalname), ",", ".") > 999999.999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENVALENRQ");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenValEnrq_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A163OrdenValEnrq = 0;
                  n163OrdenValEnrq = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163OrdenValEnrq", StringUtil.LTrim( StringUtil.Str( A163OrdenValEnrq, 10, 3)));
               }
               else
               {
                  A163OrdenValEnrq = context.localUtil.CToN( cgiGet( edtOrdenValEnrq_Internalname), ",", ".");
                  n163OrdenValEnrq = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163OrdenValEnrq", StringUtil.LTrim( StringUtil.Str( A163OrdenValEnrq, 10, 3)));
               }
               n163OrdenValEnrq = ((Convert.ToDecimal(0)==A163OrdenValEnrq) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenValCal_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenValCal_Internalname), ",", ".") > 999999.999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDENVALCAL");
                  AnyError = 1;
                  GX_FocusControl = edtOrdenValCal_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A165OrdenValCal = 0;
                  n165OrdenValCal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165OrdenValCal", StringUtil.LTrim( StringUtil.Str( A165OrdenValCal, 10, 3)));
               }
               else
               {
                  A165OrdenValCal = context.localUtil.CToN( cgiGet( edtOrdenValCal_Internalname), ",", ".");
                  n165OrdenValCal = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165OrdenValCal", StringUtil.LTrim( StringUtil.Str( A165OrdenValCal, 10, 3)));
               }
               n165OrdenValCal = ((Convert.ToDecimal(0)==A165OrdenValCal) ? true : false);
               A164OrdenValMatPri = context.localUtil.CToN( cgiGet( edtOrdenValMatPri_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164OrdenValMatPri", StringUtil.LTrim( StringUtil.Str( A164OrdenValMatPri, 10, 3)));
               A255OrdenObreSuma = context.localUtil.CToN( cgiGet( edtOrdenObreSuma_Internalname), ",", ".");
               n255OrdenObreSuma = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
               A170OrdenTotGast = context.localUtil.CToN( cgiGet( edtOrdenTotGast_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170OrdenTotGast", StringUtil.LTrim( StringUtil.Str( A170OrdenTotGast, 10, 3)));
               A171OrdenValRenta = context.localUtil.CToN( cgiGet( edtOrdenValRenta_Internalname), ",", ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171OrdenValRenta", StringUtil.LTrim( StringUtil.Str( A171OrdenValRenta, 10, 3)));
               AV22MarcaID = (short)(context.localUtil.CToN( cgiGet( edtavMarcaid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
               AV10EmpID = (short)(context.localUtil.CToN( cgiGet( edtavEmpid_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
               AV34valueNro = (short)(context.localUtil.CToN( cgiGet( edtavValuenro_Internalname), ",", "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34valueNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34valueNro), 4, 0)));
               /* Read saved values. */
               Z1EmpID = (short)(context.localUtil.CToN( cgiGet( "Z1EmpID"), ",", "."));
               Z5ClienteID = (short)(context.localUtil.CToN( cgiGet( "Z5ClienteID"), ",", "."));
               Z24OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( "Z24OrdenPeriodo"), ",", "."));
               Z25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( "Z25OrdenAnio"), ",", "."));
               Z22OrdenID = (short)(context.localUtil.CToN( cgiGet( "Z22OrdenID"), ",", "."));
               Z116OrdenUser = cgiGet( "Z116OrdenUser");
               n116OrdenUser = (String.IsNullOrEmpty(StringUtil.RTrim( A116OrdenUser)) ? true : false);
               Z115OrdenEst = cgiGet( "Z115OrdenEst");
               n115OrdenEst = (String.IsNullOrEmpty(StringUtil.RTrim( A115OrdenEst)) ? true : false);
               Z117OrdenModeloID = (short)(context.localUtil.CToN( cgiGet( "Z117OrdenModeloID"), ",", "."));
               Z119OrdenFch = context.localUtil.CToD( cgiGet( "Z119OrdenFch"), 0);
               n119OrdenFch = ((DateTime.MinValue==A119OrdenFch) ? true : false);
               Z106facturaNro = (int)(context.localUtil.CToN( cgiGet( "Z106facturaNro"), ",", "."));
               n106facturaNro = ((0==A106facturaNro) ? true : false);
               Z107representane = cgiGet( "Z107representane");
               n107representane = (String.IsNullOrEmpty(StringUtil.RTrim( A107representane)) ? true : false);
               Z203ordenNroPed = (int)(context.localUtil.CToN( cgiGet( "Z203ordenNroPed"), ",", "."));
               n203ordenNroPed = ((0==A203ordenNroPed) ? true : false);
               Z109fchVenta = context.localUtil.CToD( cgiGet( "Z109fchVenta"), 0);
               n109fchVenta = ((DateTime.MinValue==A109fchVenta) ? true : false);
               Z110cantDias = (short)(context.localUtil.CToN( cgiGet( "Z110cantDias"), ",", "."));
               n110cantDias = ((0==A110cantDias) ? true : false);
               Z132OrdenEmpFac = (short)(context.localUtil.CToN( cgiGet( "Z132OrdenEmpFac"), ",", "."));
               n132OrdenEmpFac = ((0==A132OrdenEmpFac) ? true : false);
               Z133OrdenProceso = cgiGet( "Z133OrdenProceso");
               n133OrdenProceso = (String.IsNullOrEmpty(StringUtil.RTrim( A133OrdenProceso)) ? true : false);
               Z161OrdenSubtotal = context.localUtil.CToN( cgiGet( "Z161OrdenSubtotal"), ",", ".");
               n161OrdenSubtotal = ((Convert.ToDecimal(0)==A161OrdenSubtotal) ? true : false);
               Z162OrdenValInds = context.localUtil.CToN( cgiGet( "Z162OrdenValInds"), ",", ".");
               n162OrdenValInds = ((Convert.ToDecimal(0)==A162OrdenValInds) ? true : false);
               Z163OrdenValEnrq = context.localUtil.CToN( cgiGet( "Z163OrdenValEnrq"), ",", ".");
               n163OrdenValEnrq = ((Convert.ToDecimal(0)==A163OrdenValEnrq) ? true : false);
               Z165OrdenValCal = context.localUtil.CToN( cgiGet( "Z165OrdenValCal"), ",", ".");
               n165OrdenValCal = ((Convert.ToDecimal(0)==A165OrdenValCal) ? true : false);
               Z166OrdenValPint = context.localUtil.CToN( cgiGet( "Z166OrdenValPint"), ",", ".");
               n166OrdenValPint = ((Convert.ToDecimal(0)==A166OrdenValPint) ? true : false);
               Z167OrdenValEstr = context.localUtil.CToN( cgiGet( "Z167OrdenValEstr"), ",", ".");
               n167OrdenValEstr = ((Convert.ToDecimal(0)==A167OrdenValEstr) ? true : false);
               Z168OrdenValOtrs = context.localUtil.CToN( cgiGet( "Z168OrdenValOtrs"), ",", ".");
               n168OrdenValOtrs = ((Convert.ToDecimal(0)==A168OrdenValOtrs) ? true : false);
               Z172OrdenfchEnt = context.localUtil.CToD( cgiGet( "Z172OrdenfchEnt"), 0);
               n172OrdenfchEnt = ((DateTime.MinValue==A172OrdenfchEnt) ? true : false);
               Z192OrdenPed = (int)(context.localUtil.CToN( cgiGet( "Z192OrdenPed"), ",", "."));
               n192OrdenPed = ((0==A192OrdenPed) ? true : false);
               Z195OrdenFacNomb = cgiGet( "Z195OrdenFacNomb");
               n195OrdenFacNomb = (String.IsNullOrEmpty(StringUtil.RTrim( A195OrdenFacNomb)) ? true : false);
               Z210OrdenUltSec = (short)(context.localUtil.CToN( cgiGet( "Z210OrdenUltSec"), ",", "."));
               n210OrdenUltSec = ((0==A210OrdenUltSec) ? true : false);
               Z401OrdenNroDesp = (int)(context.localUtil.CToN( cgiGet( "Z401OrdenNroDesp"), ",", "."));
               n401OrdenNroDesp = ((0==A401OrdenNroDesp) ? true : false);
               Z26OrdenMarcaID = (short)(context.localUtil.CToN( cgiGet( "Z26OrdenMarcaID"), ",", "."));
               Z8VehiculoID = (short)(context.localUtil.CToN( cgiGet( "Z8VehiculoID"), ",", "."));
               Z9vendedorID = (short)(context.localUtil.CToN( cgiGet( "Z9vendedorID"), ",", "."));
               Z10protID = (short)(context.localUtil.CToN( cgiGet( "Z10protID"), ",", "."));
               Z17tipOrdID = (short)(context.localUtil.CToN( cgiGet( "Z17tipOrdID"), ",", "."));
               A116OrdenUser = cgiGet( "Z116OrdenUser");
               n116OrdenUser = false;
               n116OrdenUser = (String.IsNullOrEmpty(StringUtil.RTrim( A116OrdenUser)) ? true : false);
               A203ordenNroPed = (int)(context.localUtil.CToN( cgiGet( "Z203ordenNroPed"), ",", "."));
               n203ordenNroPed = false;
               n203ordenNroPed = ((0==A203ordenNroPed) ? true : false);
               A166OrdenValPint = context.localUtil.CToN( cgiGet( "Z166OrdenValPint"), ",", ".");
               n166OrdenValPint = false;
               n166OrdenValPint = ((Convert.ToDecimal(0)==A166OrdenValPint) ? true : false);
               A167OrdenValEstr = context.localUtil.CToN( cgiGet( "Z167OrdenValEstr"), ",", ".");
               n167OrdenValEstr = false;
               n167OrdenValEstr = ((Convert.ToDecimal(0)==A167OrdenValEstr) ? true : false);
               A168OrdenValOtrs = context.localUtil.CToN( cgiGet( "Z168OrdenValOtrs"), ",", ".");
               n168OrdenValOtrs = false;
               n168OrdenValOtrs = ((Convert.ToDecimal(0)==A168OrdenValOtrs) ? true : false);
               A192OrdenPed = (int)(context.localUtil.CToN( cgiGet( "Z192OrdenPed"), ",", "."));
               n192OrdenPed = false;
               n192OrdenPed = ((0==A192OrdenPed) ? true : false);
               A210OrdenUltSec = (short)(context.localUtil.CToN( cgiGet( "Z210OrdenUltSec"), ",", "."));
               n210OrdenUltSec = false;
               n210OrdenUltSec = ((0==A210OrdenUltSec) ? true : false);
               O210OrdenUltSec = (short)(context.localUtil.CToN( cgiGet( "O210OrdenUltSec"), ",", "."));
               n210OrdenUltSec = ((0==A210OrdenUltSec) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", "."));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", "."));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_261 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_261"), ",", "."));
               nRC_GXsfl_216 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_216"), ",", "."));
               N8VehiculoID = (short)(context.localUtil.CToN( cgiGet( "N8VehiculoID"), ",", "."));
               N26OrdenMarcaID = (short)(context.localUtil.CToN( cgiGet( "N26OrdenMarcaID"), ",", "."));
               N17tipOrdID = (short)(context.localUtil.CToN( cgiGet( "N17tipOrdID"), ",", "."));
               N9vendedorID = (short)(context.localUtil.CToN( cgiGet( "N9vendedorID"), ",", "."));
               N10protID = (short)(context.localUtil.CToN( cgiGet( "N10protID"), ",", "."));
               AV43ordenDesp = (short)(context.localUtil.CToN( cgiGet( "ORDENDESP"), ",", "."));
               A169OrdenValManObr = context.localUtil.CToN( cgiGet( "ORDENVALMANOBR"), ",", ".");
               A166OrdenValPint = context.localUtil.CToN( cgiGet( "ORDENVALPINT"), ",", ".");
               n166OrdenValPint = ((Convert.ToDecimal(0)==A166OrdenValPint) ? true : false);
               A167OrdenValEstr = context.localUtil.CToN( cgiGet( "ORDENVALESTR"), ",", ".");
               n167OrdenValEstr = ((Convert.ToDecimal(0)==A167OrdenValEstr) ? true : false);
               A168OrdenValOtrs = context.localUtil.CToN( cgiGet( "ORDENVALOTRS"), ",", ".");
               n168OrdenValOtrs = ((Convert.ToDecimal(0)==A168OrdenValOtrs) ? true : false);
               AV9ClienteID = (short)(context.localUtil.CToN( cgiGet( "vCLIENTEID"), ",", "."));
               AV27OrdenPeriodo = (short)(context.localUtil.CToN( cgiGet( "vORDENPERIODO"), ",", "."));
               AV25OrdenAnio = (short)(context.localUtil.CToN( cgiGet( "vORDENANIO"), ",", "."));
               AV26OrdenID = (short)(context.localUtil.CToN( cgiGet( "vORDENID"), ",", "."));
               AV19Insert_VehiculoID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_VEHICULOID"), ",", "."));
               AV15Insert_OrdenMarcaID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ORDENMARCAID"), ",", "."));
               AV18Insert_tipOrdID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_TIPORDID"), ",", "."));
               AV20Insert_vendedorID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_VENDEDORID"), ",", "."));
               AV17Insert_protID = (short)(context.localUtil.CToN( cgiGet( "vINSERT_PROTID"), ",", "."));
               A116OrdenUser = cgiGet( "ORDENUSER");
               n116OrdenUser = (String.IsNullOrEmpty(StringUtil.RTrim( A116OrdenUser)) ? true : false);
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", "."));
               AV43ordenDesp = (short)(context.localUtil.CToN( cgiGet( "vORDENDESP"), ",", "."));
               A203ordenNroPed = (int)(context.localUtil.CToN( cgiGet( "ORDENNROPED"), ",", "."));
               n203ordenNroPed = ((0==A203ordenNroPed) ? true : false);
               A108urlPdf = cgiGet( "URLPDF");
               n108urlPdf = false;
               n108urlPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A108urlPdf)) ? true : false);
               A112documento = cgiGet( "DOCUMENTO");
               n112documento = false;
               n112documento = (String.IsNullOrEmpty(StringUtil.RTrim( A112documento)) ? true : false);
               A192OrdenPed = (int)(context.localUtil.CToN( cgiGet( "ORDENPED"), ",", "."));
               n192OrdenPed = ((0==A192OrdenPed) ? true : false);
               A210OrdenUltSec = (short)(context.localUtil.CToN( cgiGet( "ORDENULTSEC"), ",", "."));
               n210OrdenUltSec = ((0==A210OrdenUltSec) ? true : false);
               A57ClienteDsc = cgiGet( "CLIENTEDSC");
               n57ClienteDsc = false;
               A72vendedorDsc = cgiGet( "VENDEDORDSC");
               n72vendedorDsc = false;
               A74protDsc = cgiGet( "PROTDSC");
               n74protDsc = false;
               A104tipOrdDsc = cgiGet( "TIPORDDSC");
               n104tipOrdDsc = false;
               A6MarcaID = (short)(context.localUtil.CToN( cgiGet( "MARCAID"), ",", "."));
               AV46Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               A242ObrePrApellido = cgiGet( "OBREPRAPELLIDO");
               n242ObrePrApellido = false;
               A243ObreSegApellido = cgiGet( "OBRESEGAPELLIDO");
               n243ObreSegApellido = false;
               A240ObrePrNombre = cgiGet( "OBREPRNOMBRE");
               n240ObrePrNombre = false;
               A241ObreSegNombre = cgiGet( "OBRESEGNOMBRE");
               n241ObreSegNombre = false;
               A244ObreNombre = cgiGet( "OBRENOMBRE");
               A31tipoProdID = (short)(context.localUtil.CToN( cgiGet( "TIPOPRODID"), ",", "."));
               Tabcosteo_Objectcall = cgiGet( "TABCOSTEO_Objectcall");
               Tabcosteo_Enabled = StringUtil.StrToBool( cgiGet( "TABCOSTEO_Enabled"));
               Tabcosteo_Class = cgiGet( "TABCOSTEO_Class");
               Tabcosteo_Activepage = (int)(context.localUtil.CToN( cgiGet( "TABCOSTEO_Activepage"), ",", "."));
               Tabcosteo_Activepagecontrolname = cgiGet( "TABCOSTEO_Activepagecontrolname");
               Tabcosteo_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABCOSTEO_Pagecount"), ",", "."));
               Tabcosteo_Historymanagement = StringUtil.StrToBool( cgiGet( "TABCOSTEO_Historymanagement"));
               Tabcosteo_Visible = StringUtil.StrToBool( cgiGet( "TABCOSTEO_Visible"));
               edtOrdenPdf_Filename = cgiGet( "ORDENPDF_Filename");
               edtOrdenActaPdf_Filename = cgiGet( "ORDENACTAPDF_Filename");
               edtOrdenPdf_Filetype = cgiGet( "ORDENPDF_Filetype");
               edtOrdenActaPdf_Filetype = cgiGet( "ORDENACTAPDF_Filetype");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) )
               {
                  edtOrdenPdf_Filename = (String)(CGIGetFileName(edtOrdenPdf_Internalname));
                  edtOrdenPdf_Filetype = (String)(CGIGetFileType(edtOrdenPdf_Internalname));
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) )
               {
                  GXCCtlgxBlob = "ORDENPDF" + "_gxBlob";
                  A152OrdenPdf = cgiGet( GXCCtlgxBlob);
                  n152OrdenPdf = false;
                  n152OrdenPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) ? true : false);
               }
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) )
               {
                  edtOrdenActaPdf_Filename = (String)(CGIGetFileName(edtOrdenActaPdf_Internalname));
                  edtOrdenActaPdf_Filetype = (String)(CGIGetFileType(edtOrdenActaPdf_Internalname));
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) )
               {
                  GXCCtlgxBlob = "ORDENACTAPDF" + "_gxBlob";
                  A153OrdenActaPdf = cgiGet( GXCCtlgxBlob);
                  n153OrdenActaPdf = false;
                  n153OrdenActaPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) ? true : false);
               }
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "OrdenProduccion";
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV19Insert_VehiculoID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_OrdenMarcaID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV18Insert_tipOrdID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV20Insert_vendedorID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV17Insert_protID), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A116OrdenUser, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A203ordenNroPed), "ZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A166OrdenValPint, "ZZZZZ9.999");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A167OrdenValEstr, "ZZZZZ9.999");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A168OrdenValOtrs, "ZZZZZ9.999");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A192OrdenPed), "ZZZZZZZ9");
               AV11facEmp = (short)(((StringUtil.StrCmp(cgiGet( chkavFacemp_Internalname), "1")==0) ? 1 : 0));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11facEmp), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV43ordenDesp), "Z9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) || ( A24OrdenPeriodo != Z24OrdenPeriodo ) || ( A25OrdenAnio != Z25OrdenAnio ) || ( A22OrdenID != Z22OrdenID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Insert_VehiculoID:"+context.localUtil.Format( (decimal)(AV19Insert_VehiculoID), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Insert_OrdenMarcaID:"+context.localUtil.Format( (decimal)(AV15Insert_OrdenMarcaID), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Insert_tipOrdID:"+context.localUtil.Format( (decimal)(AV18Insert_tipOrdID), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Insert_vendedorID:"+context.localUtil.Format( (decimal)(AV20Insert_vendedorID), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Insert_protID:"+context.localUtil.Format( (decimal)(AV17Insert_protID), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"OrdenUser:"+StringUtil.RTrim( context.localUtil.Format( A116OrdenUser, "@!")));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"ordenNroPed:"+context.localUtil.Format( (decimal)(A203ordenNroPed), "ZZZZZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"OrdenValPint:"+context.localUtil.Format( A166OrdenValPint, "ZZZZZ9.999"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"OrdenValEstr:"+context.localUtil.Format( A167OrdenValEstr, "ZZZZZ9.999"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"OrdenValOtrs:"+context.localUtil.Format( A168OrdenValOtrs, "ZZZZZ9.999"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"OrdenPed:"+context.localUtil.Format( (decimal)(A192OrdenPed), "ZZZZZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"facEmp:"+context.localUtil.Format( (decimal)(AV11facEmp), "ZZZ9"));
                  GXUtil.WriteLog("ordenproduccion:[SecurityCheckFailed value for]"+"ordenDesp:"+context.localUtil.Format( (decimal)(AV43ordenDesp), "Z9"));
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
                  A5ClienteID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  A24OrdenPeriodo = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
                  A25OrdenAnio = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                  A22OrdenID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  getEqualNoModal( ) ;
                  GXACLIENTEID_html0H16( AV10EmpID) ;
                  if ( ! (0==AV25OrdenAnio) )
                  {
                     A25OrdenAnio = AV25OrdenAnio;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
                     {
                        A25OrdenAnio = AV25OrdenAnio;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                     }
                  }
                  if ( ! (0==AV26OrdenID) )
                  {
                     A22OrdenID = AV26OrdenID;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                     {
                        GXt_int1 = A22OrdenID;
                        new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
                        A22OrdenID = GXt_int1;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
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
                     sMode16 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     GXACLIENTEID_html0H16( AV10EmpID) ;
                     if ( ! (0==AV25OrdenAnio) )
                     {
                        A25OrdenAnio = AV25OrdenAnio;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
                        {
                           A25OrdenAnio = AV25OrdenAnio;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                        }
                     }
                     if ( ! (0==AV26OrdenID) )
                     {
                        A22OrdenID = AV26OrdenID;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
                        {
                           GXt_int1 = A22OrdenID;
                           new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
                           A22OrdenID = GXt_int1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                        }
                     }
                     Gx_mode = sMode16;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound16 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0H0( ) ;
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
                     if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: After Trn */
                        E120H2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: Start */
                        E110H2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "ORDENPROCESO.CLICK") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        E130H2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "CLIENTEID.CLICK") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        E140H2 ();
                     }
                     else if ( StringUtil.StrCmp(sEvt, "'EXEXCEL'") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: 'exExcel' */
                        E150H2 ();
                        nKeyPressed = 3;
                     }
                     else if ( StringUtil.StrCmp(sEvt, "'EXPORTPDF'") == 0 )
                     {
                        context.wbHandled = 1;
                        dynload_actions( ) ;
                        /* Execute user event: 'exportPdf' */
                        E160H2 ();
                        nKeyPressed = 3;
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
            E120H2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0H16( ) ;
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
               bttBtnenter2_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnenter2_Visible), 5, 0)), true);
            }
            DisableAttributes0H16( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavUsucod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavUsucod.Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavFacemp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavFacemp.Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavErrormesjtool_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavErrormesjtool_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMarcaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMarcaid_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmpid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpid_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuenro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuenro_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H16( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H16( ) ;
            }
            else
            {
               CheckExtendedTable0H16( ) ;
               CloseExtendedTableCursors0H16( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode16 = Gx_mode;
            CONFIRM_0H52( ) ;
            if ( AnyError == 0 )
            {
               CONFIRM_0H17( ) ;
               if ( AnyError == 0 )
               {
                  /* Restore parent mode. */
                  Gx_mode = sMode16;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  IsConfirmed = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
               }
            }
            /* Restore parent mode. */
            Gx_mode = sMode16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0H17( )
      {
         s210OrdenUltSec = O210OrdenUltSec;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         nGXsfl_216_idx = 0;
         while ( nGXsfl_216_idx < nRC_GXsfl_216 )
         {
            ReadRow0H17( ) ;
            if ( ( nRcdExists_17 != 0 ) || ( nIsMod_17 != 0 ) )
            {
               GetKey0H17( ) ;
               if ( ( nRcdExists_17 == 0 ) && ( nRcdDeleted_17 == 0 ) )
               {
                  if ( RcdFound17 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0H17( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0H17( ) ;
                        CloseExtendedTableCursors0H17( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                        O210OrdenUltSec = A210OrdenUltSec;
                        n210OrdenUltSec = false;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "ORDENANIO");
                     AnyError = 1;
                     GX_FocusControl = edtOrdenAnio_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound17 != 0 )
                  {
                     if ( nRcdDeleted_17 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0H17( ) ;
                        Load0H17( ) ;
                        BeforeValidate0H17( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0H17( ) ;
                           O210OrdenUltSec = A210OrdenUltSec;
                           n210OrdenUltSec = false;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_17 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0H17( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0H17( ) ;
                              CloseExtendedTableCursors0H17( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                              }
                              O210OrdenUltSec = A210OrdenUltSec;
                              n210OrdenUltSec = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_17 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ORDENANIO");
                        AnyError = 1;
                        GX_FocusControl = edtOrdenAnio_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOrdenSecId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41OrdenSecId), 4, 0, ",", ""))) ;
            ChangePostValue( dyndetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", ""))) ;
            ChangePostValue( dyncategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", ""))) ;
            ChangePostValue( edtcategDsc_Internalname, StringUtil.RTrim( A146categDsc)) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( chkOrdenDetDesp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A396OrdenDetDesp), 1, 0, ",", ""))) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A208OrdenDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetVal_Internalname, StringUtil.LTrim( StringUtil.NToC( A209OrdenDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetDetalle_Internalname, A251OrdenDetDetalle) ;
            ChangePostValue( edtOrdenDesp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A397OrdenDesp), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z41OrdenSecId_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41OrdenSecId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z208OrdenDetCant_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( Z208OrdenDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z251OrdenDetDetalle_"+sGXsfl_216_idx, Z251OrdenDetDetalle) ;
            ChangePostValue( "ZT_"+"Z396OrdenDetDesp_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z396OrdenDetDesp), 1, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z397OrdenDesp_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z397OrdenDesp), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_17), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_17), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_17), 4, 0, ",", ""))) ;
            if ( nIsMod_17 != 0 )
            {
               ChangePostValue( "ORDENSECID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenSecId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyndetTipoProdID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyncategID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkOrdenDetDesp.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETCANT_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETVAL_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetVal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETDETALLE_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDesp_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O210OrdenUltSec = s210OrdenUltSec;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0H52( )
      {
         nGXsfl_261_idx = 0;
         while ( nGXsfl_261_idx < nRC_GXsfl_261 )
         {
            ReadRow0H52( ) ;
            if ( ( nRcdExists_52 != 0 ) || ( nIsMod_52 != 0 ) )
            {
               GetKey0H52( ) ;
               if ( ( nRcdExists_52 == 0 ) && ( nRcdDeleted_52 == 0 ) )
               {
                  if ( RcdFound52 == 0 )
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0H52( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0H52( ) ;
                        CloseExtendedTableCursors0H52( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "ORDENOBRID_" + sGXsfl_261_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtOrdenObrID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound52 != 0 )
                  {
                     if ( nRcdDeleted_52 != 0 )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0H52( ) ;
                        Load0H52( ) ;
                        BeforeValidate0H52( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0H52( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_52 != 0 )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0H52( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0H52( ) ;
                              CloseExtendedTableCursors0H52( ) ;
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
                     if ( nRcdDeleted_52 == 0 )
                     {
                        GXCCtl = "ORDENOBRID_" + sGXsfl_261_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtOrdenObrID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOrdenObrID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A252OrdenObrID), 4, 0, ",", ""))) ;
            ChangePostValue( dynObreID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", ""))) ;
            ChangePostValue( edtOrdenObreManObra_Internalname, A253OrdenObreManObra) ;
            ChangePostValue( edtOrdenObreValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A254OrdenObreValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z252OrdenObrID_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z252OrdenObrID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z238ObreID_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z238ObreID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z253OrdenObreManObra_"+sGXsfl_261_idx, Z253OrdenObreManObra) ;
            ChangePostValue( "ZT_"+"Z254OrdenObreValor_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( Z254OrdenObreValor, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ",", ""))) ;
            if ( nIsMod_52 != 0 )
            {
               ChangePostValue( "ORDENOBRID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObrID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBREID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynObreID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENOBREMANOBRA_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreManObra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENOBREVALOR_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption0H0( )
      {
      }

      protected void E120H2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV29TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwordenproduccion.aspx") + "?" + UrlEncode("" +AV10EmpID) + "," + UrlEncode("" +AV7ageID) + "," + UrlEncode(StringUtil.RTrim(AV33usuCod)));
            context.wjLocDisableFrm = 1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            new addnewdespbodnro(context ).execute(  AV10EmpID,  AV7ageID,  A5ClienteID,  AV25OrdenAnio,  A24OrdenPeriodo,  A22OrdenID,  1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ageID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
            {
               if ( A401OrdenNroDesp > 0 )
               {
                  new insdespbodegaop(context ).execute(  AV10EmpID,  AV7ageID,  1,  A5ClienteID,  AV25OrdenAnio,  AV27OrdenPeriodo,  A22OrdenID) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ageID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27OrdenPeriodo), 2, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV27OrdenPeriodo), "Z9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  new addnewdespbodnro(context ).execute(  AV10EmpID,  AV7ageID,  A5ClienteID,  AV25OrdenAnio,  A24OrdenPeriodo,  A22OrdenID,  1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ageID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  new insdespbodegaop(context ).execute(  AV10EmpID,  AV7ageID,  1,  A5ClienteID,  AV25OrdenAnio,  A24OrdenPeriodo,  A22OrdenID) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ageID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ageID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
            }
         }
      }

      protected void E110H2( )
      {
         /* Start Routine */
         edtavEmpid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmpid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpid_Visible), 5, 0)), true);
         AV12fechaCtrol = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fechaCtrol", context.localUtil.Format(AV12fechaCtrol, "99/99/9999"));
         chkavFacemp.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavFacemp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavFacemp.Enabled), 5, 0)), true);
         edtavMarcaid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMarcaid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMarcaid_Visible), 5, 0)), true);
         edtavValuenro_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuenro_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuenro_Visible), 5, 0)), true);
         edtavErrormesjtool_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavErrormesjtool_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavErrormesjtool_Enabled), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            cmbOrdenEst.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenEst.Enabled), 5, 0)), true);
         }
         GXt_char2 = AV28rolUser;
         new obtrolusuario(context ).execute(  AV33usuCod, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33usuCod", AV33usuCod);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
         AV28rolUser = GXt_char2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28rolUser", AV28rolUser);
         if ( ( StringUtil.StrCmp(AV28rolUser, "ADM") == 0 ) && ( StringUtil.StrCmp(AV33usuCod, "NVERGARA") != 0 ) )
         {
            Tabcosteo_Visible = true;
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Tabcosteo_Internalname, "Visible", StringUtil.BoolToStr( Tabcosteo_Visible));
         }
         else
         {
            Tabcosteo_Visible = false;
            context.httpAjaxContext.ajax_rsp_assign_uc_prop("", false, Tabcosteo_Internalname, "Visible", StringUtil.BoolToStr( Tabcosteo_Visible));
         }
         edtOrdenfchEnt_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
         edtOrdenFacNomb_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
         if ( AV11facEmp == 0 )
         {
            divTbempfac_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTbempfac_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTbempfac_Visible), 5, 0)), true);
         }
         else
         {
            divTbempfac_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTbempfac_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divTbempfac_Visible), 5, 0)), true);
         }
         chkOrdenDetDesp.Enabled = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkOrdenDetDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkOrdenDetDesp.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         if ( ! new isauthorized(context).executeUdp(  AV46Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV46Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV29TrnContext.FromXml(AV35WebSession.Get("TrnContext"), null, "TransactionContext", "KBCalpesa22");
         AV19Insert_VehiculoID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Insert_VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19Insert_VehiculoID), 4, 0)));
         AV15Insert_OrdenMarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_OrdenMarcaID), 4, 0)));
         AV18Insert_tipOrdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Insert_tipOrdID), 4, 0)));
         AV20Insert_vendedorID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Insert_vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20Insert_vendedorID), 4, 0)));
         AV17Insert_protID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Insert_protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Insert_protID), 4, 0)));
         if ( ( StringUtil.StrCmp(AV29TrnContext.gxTpr_Transactionname, AV46Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV47GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GXV1), 8, 0)));
            while ( AV47GXV1 <= AV29TrnContext.gxTpr_Attributes.Count )
            {
               AV30TrnContextAtt = ((SdtTransactionContext_Attribute)AV29TrnContext.gxTpr_Attributes.Item(AV47GXV1));
               if ( StringUtil.StrCmp(AV30TrnContextAtt.gxTpr_Attributename, "VehiculoID") == 0 )
               {
                  AV19Insert_VehiculoID = (short)(NumberUtil.Val( AV30TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Insert_VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19Insert_VehiculoID), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV30TrnContextAtt.gxTpr_Attributename, "OrdenMarcaID") == 0 )
               {
                  AV15Insert_OrdenMarcaID = (short)(NumberUtil.Val( AV30TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Insert_OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15Insert_OrdenMarcaID), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV30TrnContextAtt.gxTpr_Attributename, "tipOrdID") == 0 )
               {
                  AV18Insert_tipOrdID = (short)(NumberUtil.Val( AV30TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Insert_tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18Insert_tipOrdID), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV30TrnContextAtt.gxTpr_Attributename, "vendedorID") == 0 )
               {
                  AV20Insert_vendedorID = (short)(NumberUtil.Val( AV30TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Insert_vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20Insert_vendedorID), 4, 0)));
               }
               else if ( StringUtil.StrCmp(AV30TrnContextAtt.gxTpr_Attributename, "protID") == 0 )
               {
                  AV17Insert_protID = (short)(NumberUtil.Val( AV30TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Insert_protID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17Insert_protID), 4, 0)));
               }
               AV47GXV1 = (int)(AV47GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV47GXV1), 8, 0)));
            }
         }
      }

      protected void E130H2( )
      {
         /* OrdenProceso_Click Routine */
         if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
         {
            edtOrdenfchEnt_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
         }
         else
         {
            A172OrdenfchEnt = DateTime.MinValue;
            n172OrdenfchEnt = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
            n172OrdenfchEnt = true;
            edtOrdenfchEnt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void E140H2( )
      {
         /* ClienteID_Click Routine */
         if ( A5ClienteID == 9999 )
         {
            edtOrdenFacNomb_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
         }
         else
         {
            A195OrdenFacNomb = "";
            n195OrdenFacNomb = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195OrdenFacNomb", A195OrdenFacNomb);
            n195OrdenFacNomb = true;
            edtOrdenFacNomb_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void E150H2( )
      {
         /* 'exExcel' Routine */
         GXt_char2 = AV36archivo;
         new excexportopdet(context ).execute(  AV10EmpID,  AV9ClienteID,  AV27OrdenPeriodo,  AV25OrdenAnio,  AV26OrdenID, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9ClienteID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ClienteID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27OrdenPeriodo), 2, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV27OrdenPeriodo), "Z9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrdenID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV26OrdenID), "ZZZ9"), context));
         AV36archivo = GXt_char2;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36archivo)) )
         {
            CallWebObject(formatLink(AV36archivo) );
            context.wjLocDisableFrm = 0;
         }
         else
         {
            AV40errorMesjTool = AV37ErrorMessage;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40errorMesjTool", AV40errorMesjTool);
         }
         /*  Sending Event outputs  */
      }

      protected void E160H2( )
      {
         /* 'exportPdf' Routine */
         CallWebObject(formatLink("apdfexportopdet.aspx") + "?" + UrlEncode("" +AV10EmpID) + "," + UrlEncode("" +AV9ClienteID) + "," + UrlEncode("" +AV27OrdenPeriodo) + "," + UrlEncode("" +AV25OrdenAnio) + "," + UrlEncode("" +AV26OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV33usuCod)));
         context.wjLocDisableFrm = 0;
      }

      protected void ZM0H16( short GX_JID )
      {
         if ( ( GX_JID == 71 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z116OrdenUser = T000H11_A116OrdenUser[0];
               Z115OrdenEst = T000H11_A115OrdenEst[0];
               Z117OrdenModeloID = T000H11_A117OrdenModeloID[0];
               Z119OrdenFch = T000H11_A119OrdenFch[0];
               Z106facturaNro = T000H11_A106facturaNro[0];
               Z107representane = T000H11_A107representane[0];
               Z203ordenNroPed = T000H11_A203ordenNroPed[0];
               Z109fchVenta = T000H11_A109fchVenta[0];
               Z110cantDias = T000H11_A110cantDias[0];
               Z132OrdenEmpFac = T000H11_A132OrdenEmpFac[0];
               Z133OrdenProceso = T000H11_A133OrdenProceso[0];
               Z161OrdenSubtotal = T000H11_A161OrdenSubtotal[0];
               Z162OrdenValInds = T000H11_A162OrdenValInds[0];
               Z163OrdenValEnrq = T000H11_A163OrdenValEnrq[0];
               Z165OrdenValCal = T000H11_A165OrdenValCal[0];
               Z166OrdenValPint = T000H11_A166OrdenValPint[0];
               Z167OrdenValEstr = T000H11_A167OrdenValEstr[0];
               Z168OrdenValOtrs = T000H11_A168OrdenValOtrs[0];
               Z172OrdenfchEnt = T000H11_A172OrdenfchEnt[0];
               Z192OrdenPed = T000H11_A192OrdenPed[0];
               Z195OrdenFacNomb = T000H11_A195OrdenFacNomb[0];
               Z210OrdenUltSec = T000H11_A210OrdenUltSec[0];
               Z401OrdenNroDesp = T000H11_A401OrdenNroDesp[0];
               Z26OrdenMarcaID = T000H11_A26OrdenMarcaID[0];
               Z8VehiculoID = T000H11_A8VehiculoID[0];
               Z9vendedorID = T000H11_A9vendedorID[0];
               Z10protID = T000H11_A10protID[0];
               Z17tipOrdID = T000H11_A17tipOrdID[0];
            }
            else
            {
               Z116OrdenUser = A116OrdenUser;
               Z115OrdenEst = A115OrdenEst;
               Z117OrdenModeloID = A117OrdenModeloID;
               Z119OrdenFch = A119OrdenFch;
               Z106facturaNro = A106facturaNro;
               Z107representane = A107representane;
               Z203ordenNroPed = A203ordenNroPed;
               Z109fchVenta = A109fchVenta;
               Z110cantDias = A110cantDias;
               Z132OrdenEmpFac = A132OrdenEmpFac;
               Z133OrdenProceso = A133OrdenProceso;
               Z161OrdenSubtotal = A161OrdenSubtotal;
               Z162OrdenValInds = A162OrdenValInds;
               Z163OrdenValEnrq = A163OrdenValEnrq;
               Z165OrdenValCal = A165OrdenValCal;
               Z166OrdenValPint = A166OrdenValPint;
               Z167OrdenValEstr = A167OrdenValEstr;
               Z168OrdenValOtrs = A168OrdenValOtrs;
               Z172OrdenfchEnt = A172OrdenfchEnt;
               Z192OrdenPed = A192OrdenPed;
               Z195OrdenFacNomb = A195OrdenFacNomb;
               Z210OrdenUltSec = A210OrdenUltSec;
               Z401OrdenNroDesp = A401OrdenNroDesp;
               Z26OrdenMarcaID = A26OrdenMarcaID;
               Z8VehiculoID = A8VehiculoID;
               Z9vendedorID = A9vendedorID;
               Z10protID = A10protID;
               Z17tipOrdID = A17tipOrdID;
            }
         }
         if ( GX_JID == -71 )
         {
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            Z116OrdenUser = A116OrdenUser;
            Z115OrdenEst = A115OrdenEst;
            Z117OrdenModeloID = A117OrdenModeloID;
            Z119OrdenFch = A119OrdenFch;
            Z106facturaNro = A106facturaNro;
            Z107representane = A107representane;
            Z203ordenNroPed = A203ordenNroPed;
            Z108urlPdf = A108urlPdf;
            Z109fchVenta = A109fchVenta;
            Z110cantDias = A110cantDias;
            Z112documento = A112documento;
            Z132OrdenEmpFac = A132OrdenEmpFac;
            Z133OrdenProceso = A133OrdenProceso;
            Z152OrdenPdf = A152OrdenPdf;
            Z153OrdenActaPdf = A153OrdenActaPdf;
            Z161OrdenSubtotal = A161OrdenSubtotal;
            Z162OrdenValInds = A162OrdenValInds;
            Z163OrdenValEnrq = A163OrdenValEnrq;
            Z165OrdenValCal = A165OrdenValCal;
            Z166OrdenValPint = A166OrdenValPint;
            Z167OrdenValEstr = A167OrdenValEstr;
            Z168OrdenValOtrs = A168OrdenValOtrs;
            Z172OrdenfchEnt = A172OrdenfchEnt;
            Z192OrdenPed = A192OrdenPed;
            Z195OrdenFacNomb = A195OrdenFacNomb;
            Z210OrdenUltSec = A210OrdenUltSec;
            Z401OrdenNroDesp = A401OrdenNroDesp;
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            Z26OrdenMarcaID = A26OrdenMarcaID;
            Z8VehiculoID = A8VehiculoID;
            Z9vendedorID = A9vendedorID;
            Z10protID = A10protID;
            Z17tipOrdID = A17tipOrdID;
            Z44empdsc = A44empdsc;
            Z57ClienteDsc = A57ClienteDsc;
            Z255OrdenObreSuma = A255OrdenObreSuma;
            Z68VehiculoPlaca = A68VehiculoPlaca;
            Z69VehiculoChasis = A69VehiculoChasis;
            Z104tipOrdDsc = A104tipOrdDsc;
            Z72vendedorDsc = A72vendedorDsc;
            Z74protDsc = A74protDsc;
         }
      }

      protected void standaloneNotModal( )
      {
         GXVvUSUCOD_html0H16( ) ;
         GXAORDENPROCESO_html0H16( ) ;
         GXAORDENEMPFAC_html0H16( ) ;
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         imgprompt_1_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_26_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0061.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"ORDENMARCAID"+"'), id:'"+"ORDENMARCAID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_5_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0051.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CLIENTEID"+"'), id:'"+"CLIENTEID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"true"+");");
         imgprompt_9_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0091.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"VENDEDORID"+"'), id:'"+"VENDEDORID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_17_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"TIPORDID"+"'), id:'"+"TIPORDID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"PROTID"+"'), id:'"+"PROTID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_8_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0081.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"VEHICULOID"+"'), id:'"+"VEHICULOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         GXAORDENMARCAID_html0H16( AV10EmpID) ;
         GXACLIENTEID_html0H16( AV10EmpID) ;
         GXAVENDEDORID_html0H16( AV10EmpID) ;
         GXATIPORDID_html0H16( AV10EmpID) ;
         GXAPROTID_html0H16( AV10EmpID) ;
         if ( ! (0==AV10EmpID) )
         {
            A1EmpID = AV10EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         }
         if ( ! (0==AV10EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         else
         {
            edtEmpID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV10EmpID) )
         {
            edtEmpID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9ClienteID) )
         {
            A5ClienteID = AV9ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         }
         if ( ! (0==AV9ClienteID) )
         {
            dynClienteID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynClienteID.Enabled), 5, 0)), true);
         }
         else
         {
            dynClienteID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynClienteID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV9ClienteID) )
         {
            dynClienteID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynClienteID.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV27OrdenPeriodo) )
         {
            A24OrdenPeriodo = AV27OrdenPeriodo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
         }
         if ( ! (0==AV27OrdenPeriodo) )
         {
            cmbOrdenPeriodo.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenPeriodo.Enabled), 5, 0)), true);
         }
         else
         {
            cmbOrdenPeriodo.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenPeriodo.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV27OrdenPeriodo) )
         {
            cmbOrdenPeriodo.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenPeriodo.Enabled), 5, 0)), true);
         }
         if ( ! (0==AV25OrdenAnio) )
         {
            edtOrdenAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenAnio_Enabled), 5, 0)), true);
         }
         else
         {
            edtOrdenAnio_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenAnio_Enabled), 5, 0)), true);
         }
         GXt_int1 = AV34valueNro;
         new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
         AV34valueNro = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34valueNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34valueNro), 4, 0)));
         if ( ! (0==AV25OrdenAnio) )
         {
            edtOrdenAnio_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenAnio_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV26OrdenID) )
         {
            edtOrdenID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         else
         {
            edtOrdenID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         if ( ! (0==AV26OrdenID) )
         {
            edtOrdenID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_VehiculoID) )
         {
            edtVehiculoID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         }
         else
         {
            edtVehiculoID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_OrdenMarcaID) )
         {
            dynOrdenMarcaID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenMarcaID.Enabled), 5, 0)), true);
         }
         else
         {
            dynOrdenMarcaID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenMarcaID.Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV18Insert_tipOrdID) )
         {
            dyntipOrdID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyntipOrdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyntipOrdID.Enabled), 5, 0)), true);
         }
         else
         {
            dyntipOrdID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyntipOrdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyntipOrdID.Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV20Insert_vendedorID) )
         {
            dynvendedorID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynvendedorID.Enabled), 5, 0)), true);
         }
         else
         {
            dynvendedorID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynvendedorID.Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_protID) )
         {
            dynprotID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynprotID.Enabled), 5, 0)), true);
         }
         else
         {
            dynprotID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynprotID.Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A115OrdenEst = "A";
            n115OrdenEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV17Insert_protID) )
         {
            A10protID = AV17Insert_protID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV20Insert_vendedorID) )
         {
            A9vendedorID = AV20Insert_vendedorID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV18Insert_tipOrdID) )
         {
            A17tipOrdID = AV18Insert_tipOrdID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_OrdenMarcaID) )
         {
            A26OrdenMarcaID = AV15Insert_OrdenMarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV19Insert_VehiculoID) )
         {
            A8VehiculoID = AV19Insert_VehiculoID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            A116OrdenUser = AV33usuCod;
            n116OrdenUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116OrdenUser", A116OrdenUser);
         }
         if ( ! (0==AV25OrdenAnio) )
         {
            A25OrdenAnio = AV25OrdenAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A25OrdenAnio = AV25OrdenAnio;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            }
         }
         if ( ! (0==AV26OrdenID) )
         {
            A22OrdenID = AV26OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A22OrdenID;
               new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
               A22OrdenID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A119OrdenFch) && ( Gx_BScreen == 0 ) )
         {
            A119OrdenFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
            n119OrdenFch = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A133OrdenProceso)) && ( Gx_BScreen == 0 ) )
         {
            A133OrdenProceso = "PEND";
            n133OrdenProceso = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==AV11facEmp) && ( Gx_BScreen == 0 ) )
         {
            AV11facEmp = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A132OrdenEmpFac) && ( Gx_BScreen == 0 ) )
         {
            A132OrdenEmpFac = 1;
            n132OrdenEmpFac = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==AV43ordenDesp) && ( Gx_BScreen == 0 ) )
         {
            AV43ordenDesp = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ordenDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43ordenDesp), 2, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
            {
               edtOrdenfchEnt_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
            }
            AV22MarcaID = A26OrdenMarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
            if ( A5ClienteID == 9999 )
            {
               edtOrdenFacNomb_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
            }
            /* Using cursor T000H12 */
            pr_default.execute(10, new Object[] {A1EmpID});
            A44empdsc = T000H12_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000H12_n44empdsc[0];
            pr_default.close(10);
            /* Using cursor T000H13 */
            pr_default.execute(11, new Object[] {A1EmpID, A5ClienteID});
            A57ClienteDsc = T000H13_A57ClienteDsc[0];
            n57ClienteDsc = T000H13_n57ClienteDsc[0];
            pr_default.close(11);
            /* Using cursor T000H16 */
            pr_default.execute(14, new Object[] {A1EmpID, A9vendedorID});
            A72vendedorDsc = T000H16_A72vendedorDsc[0];
            n72vendedorDsc = T000H16_n72vendedorDsc[0];
            pr_default.close(14);
            /* Using cursor T000H17 */
            pr_default.execute(15, new Object[] {A1EmpID, A10protID});
            A74protDsc = T000H17_A74protDsc[0];
            n74protDsc = T000H17_n74protDsc[0];
            pr_default.close(15);
            /* Using cursor T000H18 */
            pr_default.execute(16, new Object[] {A1EmpID, A17tipOrdID});
            A104tipOrdDsc = T000H18_A104tipOrdDsc[0];
            n104tipOrdDsc = T000H18_n104tipOrdDsc[0];
            pr_default.close(16);
            AV46Pgmname = "OrdenProduccion";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46Pgmname", AV46Pgmname);
            /* Using cursor T000H15 */
            pr_default.execute(13, new Object[] {A1EmpID, A8VehiculoID});
            A68VehiculoPlaca = T000H15_A68VehiculoPlaca[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
            n68VehiculoPlaca = T000H15_n68VehiculoPlaca[0];
            A69VehiculoChasis = T000H15_A69VehiculoChasis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
            n69VehiculoChasis = T000H15_n69VehiculoChasis[0];
            pr_default.close(13);
            /* Using cursor T000H21 */
            pr_default.execute(18, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            if ( (pr_default.getStatus(18) != 101) )
            {
               A255OrdenObreSuma = T000H21_A255OrdenObreSuma[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
               n255OrdenObreSuma = T000H21_n255OrdenObreSuma[0];
            }
            else
            {
               A255OrdenObreSuma = 0;
               n255OrdenObreSuma = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
            }
            pr_default.close(18);
            GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         }
      }

      protected void Load0H16( )
      {
         /* Using cursor T000H23 */
         pr_default.execute(19, new Object[] {A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound16 = 1;
            A116OrdenUser = T000H23_A116OrdenUser[0];
            n116OrdenUser = T000H23_n116OrdenUser[0];
            A115OrdenEst = T000H23_A115OrdenEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
            n115OrdenEst = T000H23_n115OrdenEst[0];
            A44empdsc = T000H23_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000H23_n44empdsc[0];
            A57ClienteDsc = T000H23_A57ClienteDsc[0];
            n57ClienteDsc = T000H23_n57ClienteDsc[0];
            A68VehiculoPlaca = T000H23_A68VehiculoPlaca[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
            n68VehiculoPlaca = T000H23_n68VehiculoPlaca[0];
            A69VehiculoChasis = T000H23_A69VehiculoChasis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
            n69VehiculoChasis = T000H23_n69VehiculoChasis[0];
            A117OrdenModeloID = T000H23_A117OrdenModeloID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117OrdenModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)));
            A119OrdenFch = T000H23_A119OrdenFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
            n119OrdenFch = T000H23_n119OrdenFch[0];
            A104tipOrdDsc = T000H23_A104tipOrdDsc[0];
            n104tipOrdDsc = T000H23_n104tipOrdDsc[0];
            A72vendedorDsc = T000H23_A72vendedorDsc[0];
            n72vendedorDsc = T000H23_n72vendedorDsc[0];
            A106facturaNro = T000H23_A106facturaNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106facturaNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A106facturaNro), 8, 0)));
            n106facturaNro = T000H23_n106facturaNro[0];
            A107representane = T000H23_A107representane[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107representane", A107representane);
            n107representane = T000H23_n107representane[0];
            A203ordenNroPed = T000H23_A203ordenNroPed[0];
            n203ordenNroPed = T000H23_n203ordenNroPed[0];
            A74protDsc = T000H23_A74protDsc[0];
            n74protDsc = T000H23_n74protDsc[0];
            A109fchVenta = T000H23_A109fchVenta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109fchVenta", context.localUtil.Format(A109fchVenta, "99/99/9999"));
            n109fchVenta = T000H23_n109fchVenta[0];
            A110cantDias = T000H23_A110cantDias[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110cantDias", StringUtil.LTrim( StringUtil.Str( (decimal)(A110cantDias), 4, 0)));
            n110cantDias = T000H23_n110cantDias[0];
            A132OrdenEmpFac = T000H23_A132OrdenEmpFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
            n132OrdenEmpFac = T000H23_n132OrdenEmpFac[0];
            A133OrdenProceso = T000H23_A133OrdenProceso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
            n133OrdenProceso = T000H23_n133OrdenProceso[0];
            A161OrdenSubtotal = T000H23_A161OrdenSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161OrdenSubtotal", StringUtil.LTrim( StringUtil.Str( A161OrdenSubtotal, 10, 3)));
            n161OrdenSubtotal = T000H23_n161OrdenSubtotal[0];
            A162OrdenValInds = T000H23_A162OrdenValInds[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162OrdenValInds", StringUtil.LTrim( StringUtil.Str( A162OrdenValInds, 10, 3)));
            n162OrdenValInds = T000H23_n162OrdenValInds[0];
            A163OrdenValEnrq = T000H23_A163OrdenValEnrq[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163OrdenValEnrq", StringUtil.LTrim( StringUtil.Str( A163OrdenValEnrq, 10, 3)));
            n163OrdenValEnrq = T000H23_n163OrdenValEnrq[0];
            A165OrdenValCal = T000H23_A165OrdenValCal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165OrdenValCal", StringUtil.LTrim( StringUtil.Str( A165OrdenValCal, 10, 3)));
            n165OrdenValCal = T000H23_n165OrdenValCal[0];
            A166OrdenValPint = T000H23_A166OrdenValPint[0];
            n166OrdenValPint = T000H23_n166OrdenValPint[0];
            A167OrdenValEstr = T000H23_A167OrdenValEstr[0];
            n167OrdenValEstr = T000H23_n167OrdenValEstr[0];
            A168OrdenValOtrs = T000H23_A168OrdenValOtrs[0];
            n168OrdenValOtrs = T000H23_n168OrdenValOtrs[0];
            A172OrdenfchEnt = T000H23_A172OrdenfchEnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
            n172OrdenfchEnt = T000H23_n172OrdenfchEnt[0];
            A192OrdenPed = T000H23_A192OrdenPed[0];
            n192OrdenPed = T000H23_n192OrdenPed[0];
            A195OrdenFacNomb = T000H23_A195OrdenFacNomb[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195OrdenFacNomb", A195OrdenFacNomb);
            n195OrdenFacNomb = T000H23_n195OrdenFacNomb[0];
            A210OrdenUltSec = T000H23_A210OrdenUltSec[0];
            n210OrdenUltSec = T000H23_n210OrdenUltSec[0];
            A401OrdenNroDesp = T000H23_A401OrdenNroDesp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401OrdenNroDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(A401OrdenNroDesp), 6, 0)));
            n401OrdenNroDesp = T000H23_n401OrdenNroDesp[0];
            A26OrdenMarcaID = T000H23_A26OrdenMarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
            A8VehiculoID = T000H23_A8VehiculoID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
            A9vendedorID = T000H23_A9vendedorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
            A10protID = T000H23_A10protID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            A17tipOrdID = T000H23_A17tipOrdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
            A255OrdenObreSuma = T000H23_A255OrdenObreSuma[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
            n255OrdenObreSuma = T000H23_n255OrdenObreSuma[0];
            A108urlPdf = T000H23_A108urlPdf[0];
            n108urlPdf = T000H23_n108urlPdf[0];
            A112documento = T000H23_A112documento[0];
            n112documento = T000H23_n112documento[0];
            A152OrdenPdf = T000H23_A152OrdenPdf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152OrdenPdf", A152OrdenPdf);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), true);
            n152OrdenPdf = T000H23_n152OrdenPdf[0];
            A153OrdenActaPdf = T000H23_A153OrdenActaPdf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153OrdenActaPdf", A153OrdenActaPdf);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), true);
            n153OrdenActaPdf = T000H23_n153OrdenActaPdf[0];
            ZM0H16( -71) ;
         }
         pr_default.close(19);
         OnLoadActions0H16( ) ;
      }

      protected void OnLoadActions0H16( )
      {
         AV46Pgmname = "OrdenProduccion";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46Pgmname", AV46Pgmname);
         if ( A5ClienteID == 9999 )
         {
            edtOrdenFacNomb_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
         }
         AV22MarcaID = A26OrdenMarcaID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
         {
            edtOrdenfchEnt_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
         }
         A164OrdenValMatPri = NumberUtil.Round( (A162OrdenValInds+A163OrdenValEnrq+A165OrdenValCal), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164OrdenValMatPri", StringUtil.LTrim( StringUtil.Str( A164OrdenValMatPri, 10, 3)));
         A169OrdenValManObr = NumberUtil.Round( (A166OrdenValPint+A167OrdenValEstr+A168OrdenValOtrs), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169OrdenValManObr", StringUtil.LTrim( StringUtil.Str( A169OrdenValManObr, 10, 3)));
         A170OrdenTotGast = NumberUtil.Round( (A164OrdenValMatPri+A169OrdenValManObr), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170OrdenTotGast", StringUtil.LTrim( StringUtil.Str( A170OrdenTotGast, 10, 3)));
         A171OrdenValRenta = NumberUtil.Round( (A161OrdenSubtotal-A170OrdenTotGast), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171OrdenValRenta", StringUtil.LTrim( StringUtil.Str( A171OrdenValRenta, 10, 3)));
      }

      protected void CheckExtendedTable0H16( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV46Pgmname = "OrdenProduccion";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46Pgmname", AV46Pgmname);
         /* Using cursor T000H12 */
         pr_default.execute(10, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000H12_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000H12_n44empdsc[0];
         pr_default.close(10);
         /* Using cursor T000H14 */
         pr_default.execute(12, new Object[] {A1EmpID, A26OrdenMarcaID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(12);
         /* Using cursor T000H15 */
         pr_default.execute(13, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Vehiculos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A68VehiculoPlaca = T000H15_A68VehiculoPlaca[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
         n68VehiculoPlaca = T000H15_n68VehiculoPlaca[0];
         A69VehiculoChasis = T000H15_A69VehiculoChasis[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
         n69VehiculoChasis = T000H15_n69VehiculoChasis[0];
         pr_default.close(13);
         /* Using cursor T000H16 */
         pr_default.execute(14, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'Vendedor'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A72vendedorDsc = T000H16_A72vendedorDsc[0];
         n72vendedorDsc = T000H16_n72vendedorDsc[0];
         pr_default.close(14);
         /* Using cursor T000H17 */
         pr_default.execute(15, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A74protDsc = T000H17_A74protDsc[0];
         n74protDsc = T000H17_n74protDsc[0];
         pr_default.close(15);
         /* Using cursor T000H18 */
         pr_default.execute(16, new Object[] {A1EmpID, A17tipOrdID});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A104tipOrdDsc = T000H18_A104tipOrdDsc[0];
         n104tipOrdDsc = T000H18_n104tipOrdDsc[0];
         pr_default.close(16);
         /* Using cursor T000H13 */
         pr_default.execute(11, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A57ClienteDsc = T000H13_A57ClienteDsc[0];
         n57ClienteDsc = T000H13_n57ClienteDsc[0];
         pr_default.close(11);
         if ( A5ClienteID == 9999 )
         {
            edtOrdenFacNomb_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
         }
         if ( A24OrdenPeriodo == 0 )
         {
            GX_msglist.addItem("Debe seleccionar el mes ", 1, "ORDENPERIODO");
            AnyError = 1;
            GX_FocusControl = cmbOrdenPeriodo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000H21 */
         pr_default.execute(18, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         if ( (pr_default.getStatus(18) != 101) )
         {
            A255OrdenObreSuma = T000H21_A255OrdenObreSuma[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
            n255OrdenObreSuma = T000H21_n255OrdenObreSuma[0];
         }
         else
         {
            A255OrdenObreSuma = 0;
            n255OrdenObreSuma = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
         }
         pr_default.close(18);
         AV22MarcaID = A26OrdenMarcaID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         if ( ! ( (DateTime.MinValue==A119OrdenFch) || ( A119OrdenFch >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Orden Fch fuera de rango", "OutOfRange", 1, "ORDENFCH");
            AnyError = 1;
            GX_FocusControl = edtOrdenFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A109fchVenta) || ( A109fchVenta >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Venta fuera de rango", "OutOfRange", 1, "FCHVENTA");
            AnyError = 1;
            GX_FocusControl = edtfchVenta_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
         {
            edtOrdenfchEnt_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
         }
         A164OrdenValMatPri = NumberUtil.Round( (A162OrdenValInds+A163OrdenValEnrq+A165OrdenValCal), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164OrdenValMatPri", StringUtil.LTrim( StringUtil.Str( A164OrdenValMatPri, 10, 3)));
         if ( ! ( (DateTime.MinValue==A172OrdenfchEnt) || ( A172OrdenfchEnt >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha Entrega fuera de rango", "OutOfRange", 1, "ORDENFCHENT");
            AnyError = 1;
            GX_FocusControl = edtOrdenfchEnt_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A169OrdenValManObr = NumberUtil.Round( (A166OrdenValPint+A167OrdenValEstr+A168OrdenValOtrs), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169OrdenValManObr", StringUtil.LTrim( StringUtil.Str( A169OrdenValManObr, 10, 3)));
         A170OrdenTotGast = NumberUtil.Round( (A164OrdenValMatPri+A169OrdenValManObr), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170OrdenTotGast", StringUtil.LTrim( StringUtil.Str( A170OrdenTotGast, 10, 3)));
         A171OrdenValRenta = NumberUtil.Round( (A161OrdenSubtotal-A170OrdenTotGast), 2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171OrdenValRenta", StringUtil.LTrim( StringUtil.Str( A171OrdenValRenta, 10, 3)));
      }

      protected void CloseExtendedTableCursors0H16( )
      {
         pr_default.close(10);
         pr_default.close(17);
         pr_default.close(13);
         pr_default.close(14);
         pr_default.close(15);
         pr_default.close(16);
         pr_default.close(11);
         pr_default.close(18);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_72( short A1EmpID )
      {
         /* Using cursor T000H24 */
         pr_default.execute(20, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A44empdsc = T000H24_A44empdsc[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         n44empdsc = T000H24_n44empdsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A44empdsc)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(20);
      }

      protected void gxLoad_74( short A1EmpID ,
                                short A26OrdenMarcaID )
      {
         /* Using cursor T000H14 */
         pr_default.execute(12, new Object[] {A1EmpID, A26OrdenMarcaID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(12);
      }

      protected void gxLoad_75( short A1EmpID ,
                                short A8VehiculoID )
      {
         /* Using cursor T000H25 */
         pr_default.execute(21, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No existe 'Vehiculos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A68VehiculoPlaca = T000H25_A68VehiculoPlaca[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
         n68VehiculoPlaca = T000H25_n68VehiculoPlaca[0];
         A69VehiculoChasis = T000H25_A69VehiculoChasis[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
         n69VehiculoChasis = T000H25_n69VehiculoChasis[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A68VehiculoPlaca)+"\""+","+"\""+GXUtil.EncodeJSConstant( A69VehiculoChasis)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(21) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(21);
      }

      protected void gxLoad_76( short A1EmpID ,
                                short A9vendedorID )
      {
         /* Using cursor T000H26 */
         pr_default.execute(22, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(22) == 101) )
         {
            GX_msglist.addItem("No existe 'Vendedor'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A72vendedorDsc = T000H26_A72vendedorDsc[0];
         n72vendedorDsc = T000H26_n72vendedorDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A72vendedorDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(22) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(22);
      }

      protected void gxLoad_77( short A1EmpID ,
                                short A10protID )
      {
         /* Using cursor T000H27 */
         pr_default.execute(23, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A74protDsc = T000H27_A74protDsc[0];
         n74protDsc = T000H27_n74protDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A74protDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(23) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(23);
      }

      protected void gxLoad_78( short A1EmpID ,
                                short A17tipOrdID )
      {
         /* Using cursor T000H28 */
         pr_default.execute(24, new Object[] {A1EmpID, A17tipOrdID});
         if ( (pr_default.getStatus(24) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A104tipOrdDsc = T000H28_A104tipOrdDsc[0];
         n104tipOrdDsc = T000H28_n104tipOrdDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A104tipOrdDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(24) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(24);
      }

      protected void gxLoad_73( short A1EmpID ,
                                short A5ClienteID )
      {
         /* Using cursor T000H29 */
         pr_default.execute(25, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A57ClienteDsc = T000H29_A57ClienteDsc[0];
         n57ClienteDsc = T000H29_n57ClienteDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A57ClienteDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(25) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(25);
      }

      protected void gxLoad_80( short A1EmpID ,
                                short A5ClienteID ,
                                short A24OrdenPeriodo ,
                                short A25OrdenAnio ,
                                short A22OrdenID )
      {
         /* Using cursor T000H31 */
         pr_default.execute(26, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         if ( (pr_default.getStatus(26) != 101) )
         {
            A255OrdenObreSuma = T000H31_A255OrdenObreSuma[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
            n255OrdenObreSuma = T000H31_n255OrdenObreSuma[0];
         }
         else
         {
            A255OrdenObreSuma = 0;
            n255OrdenObreSuma = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A255OrdenObreSuma, 10, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(26) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(26);
      }

      protected void GetKey0H16( )
      {
         /* Using cursor T000H32 */
         pr_default.execute(27, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound16 = 1;
         }
         else
         {
            RcdFound16 = 0;
         }
         pr_default.close(27);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000H11 */
         pr_default.execute(9, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            ZM0H16( 71) ;
            RcdFound16 = 1;
            A24OrdenPeriodo = T000H11_A24OrdenPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            A25OrdenAnio = T000H11_A25OrdenAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            A22OrdenID = T000H11_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            A116OrdenUser = T000H11_A116OrdenUser[0];
            n116OrdenUser = T000H11_n116OrdenUser[0];
            A115OrdenEst = T000H11_A115OrdenEst[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
            n115OrdenEst = T000H11_n115OrdenEst[0];
            A117OrdenModeloID = T000H11_A117OrdenModeloID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117OrdenModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)));
            A119OrdenFch = T000H11_A119OrdenFch[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
            n119OrdenFch = T000H11_n119OrdenFch[0];
            A106facturaNro = T000H11_A106facturaNro[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106facturaNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A106facturaNro), 8, 0)));
            n106facturaNro = T000H11_n106facturaNro[0];
            A107representane = T000H11_A107representane[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107representane", A107representane);
            n107representane = T000H11_n107representane[0];
            A203ordenNroPed = T000H11_A203ordenNroPed[0];
            n203ordenNroPed = T000H11_n203ordenNroPed[0];
            A109fchVenta = T000H11_A109fchVenta[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109fchVenta", context.localUtil.Format(A109fchVenta, "99/99/9999"));
            n109fchVenta = T000H11_n109fchVenta[0];
            A110cantDias = T000H11_A110cantDias[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110cantDias", StringUtil.LTrim( StringUtil.Str( (decimal)(A110cantDias), 4, 0)));
            n110cantDias = T000H11_n110cantDias[0];
            A132OrdenEmpFac = T000H11_A132OrdenEmpFac[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
            n132OrdenEmpFac = T000H11_n132OrdenEmpFac[0];
            A133OrdenProceso = T000H11_A133OrdenProceso[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
            n133OrdenProceso = T000H11_n133OrdenProceso[0];
            A161OrdenSubtotal = T000H11_A161OrdenSubtotal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161OrdenSubtotal", StringUtil.LTrim( StringUtil.Str( A161OrdenSubtotal, 10, 3)));
            n161OrdenSubtotal = T000H11_n161OrdenSubtotal[0];
            A162OrdenValInds = T000H11_A162OrdenValInds[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162OrdenValInds", StringUtil.LTrim( StringUtil.Str( A162OrdenValInds, 10, 3)));
            n162OrdenValInds = T000H11_n162OrdenValInds[0];
            A163OrdenValEnrq = T000H11_A163OrdenValEnrq[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163OrdenValEnrq", StringUtil.LTrim( StringUtil.Str( A163OrdenValEnrq, 10, 3)));
            n163OrdenValEnrq = T000H11_n163OrdenValEnrq[0];
            A165OrdenValCal = T000H11_A165OrdenValCal[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165OrdenValCal", StringUtil.LTrim( StringUtil.Str( A165OrdenValCal, 10, 3)));
            n165OrdenValCal = T000H11_n165OrdenValCal[0];
            A166OrdenValPint = T000H11_A166OrdenValPint[0];
            n166OrdenValPint = T000H11_n166OrdenValPint[0];
            A167OrdenValEstr = T000H11_A167OrdenValEstr[0];
            n167OrdenValEstr = T000H11_n167OrdenValEstr[0];
            A168OrdenValOtrs = T000H11_A168OrdenValOtrs[0];
            n168OrdenValOtrs = T000H11_n168OrdenValOtrs[0];
            A172OrdenfchEnt = T000H11_A172OrdenfchEnt[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
            n172OrdenfchEnt = T000H11_n172OrdenfchEnt[0];
            A192OrdenPed = T000H11_A192OrdenPed[0];
            n192OrdenPed = T000H11_n192OrdenPed[0];
            A195OrdenFacNomb = T000H11_A195OrdenFacNomb[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195OrdenFacNomb", A195OrdenFacNomb);
            n195OrdenFacNomb = T000H11_n195OrdenFacNomb[0];
            A210OrdenUltSec = T000H11_A210OrdenUltSec[0];
            n210OrdenUltSec = T000H11_n210OrdenUltSec[0];
            A401OrdenNroDesp = T000H11_A401OrdenNroDesp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401OrdenNroDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(A401OrdenNroDesp), 6, 0)));
            n401OrdenNroDesp = T000H11_n401OrdenNroDesp[0];
            A1EmpID = T000H11_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = T000H11_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A26OrdenMarcaID = T000H11_A26OrdenMarcaID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
            A8VehiculoID = T000H11_A8VehiculoID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
            A9vendedorID = T000H11_A9vendedorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
            A10protID = T000H11_A10protID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
            A17tipOrdID = T000H11_A17tipOrdID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
            A108urlPdf = T000H11_A108urlPdf[0];
            n108urlPdf = T000H11_n108urlPdf[0];
            A112documento = T000H11_A112documento[0];
            n112documento = T000H11_n112documento[0];
            A152OrdenPdf = T000H11_A152OrdenPdf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152OrdenPdf", A152OrdenPdf);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), true);
            n152OrdenPdf = T000H11_n152OrdenPdf[0];
            A153OrdenActaPdf = T000H11_A153OrdenActaPdf[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153OrdenActaPdf", A153OrdenActaPdf);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), true);
            n153OrdenActaPdf = T000H11_n153OrdenActaPdf[0];
            O210OrdenUltSec = A210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0H16( ) ;
            if ( AnyError == 1 )
            {
               RcdFound16 = 0;
               InitializeNonKey0H16( ) ;
            }
            Gx_mode = sMode16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound16 = 0;
            InitializeNonKey0H16( ) ;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(9);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H16( ) ;
         if ( RcdFound16 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound16 = 0;
         /* Using cursor T000H33 */
         pr_default.execute(28, new Object[] {A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(28) != 101) )
         {
            while ( (pr_default.getStatus(28) != 101) && ( ( T000H33_A24OrdenPeriodo[0] < A24OrdenPeriodo ) || ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A25OrdenAnio[0] < A25OrdenAnio ) || ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A22OrdenID[0] < A22OrdenID ) || ( T000H33_A22OrdenID[0] == A22OrdenID ) && ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A1EmpID[0] < A1EmpID ) || ( T000H33_A1EmpID[0] == A1EmpID ) && ( T000H33_A22OrdenID[0] == A22OrdenID ) && ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A5ClienteID[0] < A5ClienteID ) ) )
            {
               pr_default.readNext(28);
            }
            if ( (pr_default.getStatus(28) != 101) && ( ( T000H33_A24OrdenPeriodo[0] > A24OrdenPeriodo ) || ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A25OrdenAnio[0] > A25OrdenAnio ) || ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A22OrdenID[0] > A22OrdenID ) || ( T000H33_A22OrdenID[0] == A22OrdenID ) && ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A1EmpID[0] > A1EmpID ) || ( T000H33_A1EmpID[0] == A1EmpID ) && ( T000H33_A22OrdenID[0] == A22OrdenID ) && ( T000H33_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H33_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H33_A5ClienteID[0] > A5ClienteID ) ) )
            {
               A24OrdenPeriodo = T000H33_A24OrdenPeriodo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
               A25OrdenAnio = T000H33_A25OrdenAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
               A22OrdenID = T000H33_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A1EmpID = T000H33_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A5ClienteID = T000H33_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound16 = 1;
            }
         }
         pr_default.close(28);
      }

      protected void move_previous( )
      {
         RcdFound16 = 0;
         /* Using cursor T000H34 */
         pr_default.execute(29, new Object[] {A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(29) != 101) )
         {
            while ( (pr_default.getStatus(29) != 101) && ( ( T000H34_A24OrdenPeriodo[0] > A24OrdenPeriodo ) || ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A25OrdenAnio[0] > A25OrdenAnio ) || ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A22OrdenID[0] > A22OrdenID ) || ( T000H34_A22OrdenID[0] == A22OrdenID ) && ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A1EmpID[0] > A1EmpID ) || ( T000H34_A1EmpID[0] == A1EmpID ) && ( T000H34_A22OrdenID[0] == A22OrdenID ) && ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A5ClienteID[0] > A5ClienteID ) ) )
            {
               pr_default.readNext(29);
            }
            if ( (pr_default.getStatus(29) != 101) && ( ( T000H34_A24OrdenPeriodo[0] < A24OrdenPeriodo ) || ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A25OrdenAnio[0] < A25OrdenAnio ) || ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A22OrdenID[0] < A22OrdenID ) || ( T000H34_A22OrdenID[0] == A22OrdenID ) && ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A1EmpID[0] < A1EmpID ) || ( T000H34_A1EmpID[0] == A1EmpID ) && ( T000H34_A22OrdenID[0] == A22OrdenID ) && ( T000H34_A25OrdenAnio[0] == A25OrdenAnio ) && ( T000H34_A24OrdenPeriodo[0] == A24OrdenPeriodo ) && ( T000H34_A5ClienteID[0] < A5ClienteID ) ) )
            {
               A24OrdenPeriodo = T000H34_A24OrdenPeriodo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
               A25OrdenAnio = T000H34_A25OrdenAnio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
               A22OrdenID = T000H34_A22OrdenID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
               A1EmpID = T000H34_A1EmpID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
               A5ClienteID = T000H34_A5ClienteID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
               RcdFound16 = 1;
            }
         }
         pr_default.close(29);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0H16( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            A210OrdenUltSec = O210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            GX_FocusControl = edtOrdenFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0H16( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound16 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) || ( A24OrdenPeriodo != Z24OrdenPeriodo ) || ( A25OrdenAnio != Z25OrdenAnio ) || ( A22OrdenID != Z22OrdenID ) )
               {
                  A1EmpID = Z1EmpID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
                  A5ClienteID = Z5ClienteID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
                  A24OrdenPeriodo = Z24OrdenPeriodo;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
                  A25OrdenAnio = Z25OrdenAnio;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
                  A22OrdenID = Z22OrdenID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "EMPID");
                  AnyError = 1;
                  GX_FocusControl = edtEmpID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  A210OrdenUltSec = O210OrdenUltSec;
                  n210OrdenUltSec = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtOrdenFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  A210OrdenUltSec = O210OrdenUltSec;
                  n210OrdenUltSec = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                  Update0H16( ) ;
                  GX_FocusControl = edtOrdenFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) || ( A24OrdenPeriodo != Z24OrdenPeriodo ) || ( A25OrdenAnio != Z25OrdenAnio ) || ( A22OrdenID != Z22OrdenID ) )
               {
                  /* Insert record */
                  A210OrdenUltSec = O210OrdenUltSec;
                  n210OrdenUltSec = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                  GX_FocusControl = edtOrdenFch_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0H16( ) ;
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
                     A210OrdenUltSec = O210OrdenUltSec;
                     n210OrdenUltSec = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                     GX_FocusControl = edtOrdenFch_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0H16( ) ;
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
         if ( ( A1EmpID != Z1EmpID ) || ( A5ClienteID != Z5ClienteID ) || ( A24OrdenPeriodo != Z24OrdenPeriodo ) || ( A25OrdenAnio != Z25OrdenAnio ) || ( A22OrdenID != Z22OrdenID ) )
         {
            A1EmpID = Z1EmpID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = Z5ClienteID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A24OrdenPeriodo = Z24OrdenPeriodo;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            A25OrdenAnio = Z25OrdenAnio;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            A22OrdenID = Z22OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A210OrdenUltSec = O210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtOrdenFch_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0H16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H10 */
            pr_default.execute(8, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccion"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z116OrdenUser, T000H10_A116OrdenUser[0]) != 0 ) || ( StringUtil.StrCmp(Z115OrdenEst, T000H10_A115OrdenEst[0]) != 0 ) || ( Z117OrdenModeloID != T000H10_A117OrdenModeloID[0] ) || ( Z119OrdenFch != T000H10_A119OrdenFch[0] ) || ( Z106facturaNro != T000H10_A106facturaNro[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z107representane, T000H10_A107representane[0]) != 0 ) || ( Z203ordenNroPed != T000H10_A203ordenNroPed[0] ) || ( Z109fchVenta != T000H10_A109fchVenta[0] ) || ( Z110cantDias != T000H10_A110cantDias[0] ) || ( Z132OrdenEmpFac != T000H10_A132OrdenEmpFac[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z133OrdenProceso, T000H10_A133OrdenProceso[0]) != 0 ) || ( Z161OrdenSubtotal != T000H10_A161OrdenSubtotal[0] ) || ( Z162OrdenValInds != T000H10_A162OrdenValInds[0] ) || ( Z163OrdenValEnrq != T000H10_A163OrdenValEnrq[0] ) || ( Z165OrdenValCal != T000H10_A165OrdenValCal[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z166OrdenValPint != T000H10_A166OrdenValPint[0] ) || ( Z167OrdenValEstr != T000H10_A167OrdenValEstr[0] ) || ( Z168OrdenValOtrs != T000H10_A168OrdenValOtrs[0] ) || ( Z172OrdenfchEnt != T000H10_A172OrdenfchEnt[0] ) || ( Z192OrdenPed != T000H10_A192OrdenPed[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z195OrdenFacNomb, T000H10_A195OrdenFacNomb[0]) != 0 ) || ( Z210OrdenUltSec != T000H10_A210OrdenUltSec[0] ) || ( Z401OrdenNroDesp != T000H10_A401OrdenNroDesp[0] ) || ( Z26OrdenMarcaID != T000H10_A26OrdenMarcaID[0] ) || ( Z8VehiculoID != T000H10_A8VehiculoID[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z9vendedorID != T000H10_A9vendedorID[0] ) || ( Z10protID != T000H10_A10protID[0] ) || ( Z17tipOrdID != T000H10_A17tipOrdID[0] ) )
            {
               if ( StringUtil.StrCmp(Z116OrdenUser, T000H10_A116OrdenUser[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenUser");
                  GXUtil.WriteLogRaw("Old: ",Z116OrdenUser);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A116OrdenUser[0]);
               }
               if ( StringUtil.StrCmp(Z115OrdenEst, T000H10_A115OrdenEst[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenEst");
                  GXUtil.WriteLogRaw("Old: ",Z115OrdenEst);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A115OrdenEst[0]);
               }
               if ( Z117OrdenModeloID != T000H10_A117OrdenModeloID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenModeloID");
                  GXUtil.WriteLogRaw("Old: ",Z117OrdenModeloID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A117OrdenModeloID[0]);
               }
               if ( Z119OrdenFch != T000H10_A119OrdenFch[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenFch");
                  GXUtil.WriteLogRaw("Old: ",Z119OrdenFch);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A119OrdenFch[0]);
               }
               if ( Z106facturaNro != T000H10_A106facturaNro[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"facturaNro");
                  GXUtil.WriteLogRaw("Old: ",Z106facturaNro);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A106facturaNro[0]);
               }
               if ( StringUtil.StrCmp(Z107representane, T000H10_A107representane[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"representane");
                  GXUtil.WriteLogRaw("Old: ",Z107representane);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A107representane[0]);
               }
               if ( Z203ordenNroPed != T000H10_A203ordenNroPed[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"ordenNroPed");
                  GXUtil.WriteLogRaw("Old: ",Z203ordenNroPed);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A203ordenNroPed[0]);
               }
               if ( Z109fchVenta != T000H10_A109fchVenta[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"fchVenta");
                  GXUtil.WriteLogRaw("Old: ",Z109fchVenta);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A109fchVenta[0]);
               }
               if ( Z110cantDias != T000H10_A110cantDias[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"cantDias");
                  GXUtil.WriteLogRaw("Old: ",Z110cantDias);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A110cantDias[0]);
               }
               if ( Z132OrdenEmpFac != T000H10_A132OrdenEmpFac[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenEmpFac");
                  GXUtil.WriteLogRaw("Old: ",Z132OrdenEmpFac);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A132OrdenEmpFac[0]);
               }
               if ( StringUtil.StrCmp(Z133OrdenProceso, T000H10_A133OrdenProceso[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenProceso");
                  GXUtil.WriteLogRaw("Old: ",Z133OrdenProceso);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A133OrdenProceso[0]);
               }
               if ( Z161OrdenSubtotal != T000H10_A161OrdenSubtotal[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenSubtotal");
                  GXUtil.WriteLogRaw("Old: ",Z161OrdenSubtotal);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A161OrdenSubtotal[0]);
               }
               if ( Z162OrdenValInds != T000H10_A162OrdenValInds[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValInds");
                  GXUtil.WriteLogRaw("Old: ",Z162OrdenValInds);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A162OrdenValInds[0]);
               }
               if ( Z163OrdenValEnrq != T000H10_A163OrdenValEnrq[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValEnrq");
                  GXUtil.WriteLogRaw("Old: ",Z163OrdenValEnrq);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A163OrdenValEnrq[0]);
               }
               if ( Z165OrdenValCal != T000H10_A165OrdenValCal[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValCal");
                  GXUtil.WriteLogRaw("Old: ",Z165OrdenValCal);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A165OrdenValCal[0]);
               }
               if ( Z166OrdenValPint != T000H10_A166OrdenValPint[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValPint");
                  GXUtil.WriteLogRaw("Old: ",Z166OrdenValPint);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A166OrdenValPint[0]);
               }
               if ( Z167OrdenValEstr != T000H10_A167OrdenValEstr[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValEstr");
                  GXUtil.WriteLogRaw("Old: ",Z167OrdenValEstr);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A167OrdenValEstr[0]);
               }
               if ( Z168OrdenValOtrs != T000H10_A168OrdenValOtrs[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenValOtrs");
                  GXUtil.WriteLogRaw("Old: ",Z168OrdenValOtrs);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A168OrdenValOtrs[0]);
               }
               if ( Z172OrdenfchEnt != T000H10_A172OrdenfchEnt[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenfchEnt");
                  GXUtil.WriteLogRaw("Old: ",Z172OrdenfchEnt);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A172OrdenfchEnt[0]);
               }
               if ( Z192OrdenPed != T000H10_A192OrdenPed[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenPed");
                  GXUtil.WriteLogRaw("Old: ",Z192OrdenPed);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A192OrdenPed[0]);
               }
               if ( StringUtil.StrCmp(Z195OrdenFacNomb, T000H10_A195OrdenFacNomb[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenFacNomb");
                  GXUtil.WriteLogRaw("Old: ",Z195OrdenFacNomb);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A195OrdenFacNomb[0]);
               }
               if ( Z210OrdenUltSec != T000H10_A210OrdenUltSec[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenUltSec");
                  GXUtil.WriteLogRaw("Old: ",Z210OrdenUltSec);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A210OrdenUltSec[0]);
               }
               if ( Z401OrdenNroDesp != T000H10_A401OrdenNroDesp[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenNroDesp");
                  GXUtil.WriteLogRaw("Old: ",Z401OrdenNroDesp);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A401OrdenNroDesp[0]);
               }
               if ( Z26OrdenMarcaID != T000H10_A26OrdenMarcaID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenMarcaID");
                  GXUtil.WriteLogRaw("Old: ",Z26OrdenMarcaID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A26OrdenMarcaID[0]);
               }
               if ( Z8VehiculoID != T000H10_A8VehiculoID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"VehiculoID");
                  GXUtil.WriteLogRaw("Old: ",Z8VehiculoID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A8VehiculoID[0]);
               }
               if ( Z9vendedorID != T000H10_A9vendedorID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"vendedorID");
                  GXUtil.WriteLogRaw("Old: ",Z9vendedorID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A9vendedorID[0]);
               }
               if ( Z10protID != T000H10_A10protID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"protID");
                  GXUtil.WriteLogRaw("Old: ",Z10protID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A10protID[0]);
               }
               if ( Z17tipOrdID != T000H10_A17tipOrdID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"tipOrdID");
                  GXUtil.WriteLogRaw("Old: ",Z17tipOrdID);
                  GXUtil.WriteLogRaw("Current: ",T000H10_A17tipOrdID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenProduccion"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H16( )
      {
         BeforeValidate0H16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H16( 0) ;
            CheckOptimisticConcurrency0H16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H35 */
                     pr_default.execute(30, new Object[] {A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, n116OrdenUser, A116OrdenUser, n115OrdenEst, A115OrdenEst, A117OrdenModeloID, n119OrdenFch, A119OrdenFch, n106facturaNro, A106facturaNro, n107representane, A107representane, n203ordenNroPed, A203ordenNroPed, n108urlPdf, A108urlPdf, n109fchVenta, A109fchVenta, n110cantDias, A110cantDias, n112documento, A112documento, n132OrdenEmpFac, A132OrdenEmpFac, n133OrdenProceso, A133OrdenProceso, n152OrdenPdf, A152OrdenPdf, n153OrdenActaPdf, A153OrdenActaPdf, n161OrdenSubtotal, A161OrdenSubtotal, n162OrdenValInds, A162OrdenValInds, n163OrdenValEnrq, A163OrdenValEnrq, n165OrdenValCal, A165OrdenValCal, n166OrdenValPint, A166OrdenValPint, n167OrdenValEstr, A167OrdenValEstr, n168OrdenValOtrs, A168OrdenValOtrs, n172OrdenfchEnt, A172OrdenfchEnt, n192OrdenPed, A192OrdenPed, n195OrdenFacNomb, A195OrdenFacNomb, n210OrdenUltSec, A210OrdenUltSec, n401OrdenNroDesp, A401OrdenNroDesp, A1EmpID, A5ClienteID, A26OrdenMarcaID, A8VehiculoID, A9vendedorID, A10protID, A17tipOrdID});
                     pr_default.close(30);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
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
                           ProcessLevel0H16( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption0H0( ) ;
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
               Load0H16( ) ;
            }
            EndLevel0H16( ) ;
         }
         CloseExtendedTableCursors0H16( ) ;
      }

      protected void Update0H16( )
      {
         BeforeValidate0H16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H36 */
                     pr_default.execute(31, new Object[] {n116OrdenUser, A116OrdenUser, n115OrdenEst, A115OrdenEst, A117OrdenModeloID, n119OrdenFch, A119OrdenFch, n106facturaNro, A106facturaNro, n107representane, A107representane, n203ordenNroPed, A203ordenNroPed, n109fchVenta, A109fchVenta, n110cantDias, A110cantDias, n132OrdenEmpFac, A132OrdenEmpFac, n133OrdenProceso, A133OrdenProceso, n161OrdenSubtotal, A161OrdenSubtotal, n162OrdenValInds, A162OrdenValInds, n163OrdenValEnrq, A163OrdenValEnrq, n165OrdenValCal, A165OrdenValCal, n166OrdenValPint, A166OrdenValPint, n167OrdenValEstr, A167OrdenValEstr, n168OrdenValOtrs, A168OrdenValOtrs, n172OrdenfchEnt, A172OrdenfchEnt, n192OrdenPed, A192OrdenPed, n195OrdenFacNomb, A195OrdenFacNomb, n210OrdenUltSec, A210OrdenUltSec, n401OrdenNroDesp, A401OrdenNroDesp, A26OrdenMarcaID, A8VehiculoID, A9vendedorID, A10protID, A17tipOrdID, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
                     pr_default.close(31);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
                     if ( (pr_default.getStatus(31) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccion"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H16( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0H16( ) ;
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
            EndLevel0H16( ) ;
         }
         CloseExtendedTableCursors0H16( ) ;
      }

      protected void DeferredUpdate0H16( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T000H37 */
            pr_default.execute(32, new Object[] {n108urlPdf, A108urlPdf, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            pr_default.close(32);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H38 */
            pr_default.execute(33, new Object[] {n112documento, A112documento, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            pr_default.close(33);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H39 */
            pr_default.execute(34, new Object[] {n152OrdenPdf, A152OrdenPdf, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            pr_default.close(34);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H40 */
            pr_default.execute(35, new Object[] {n153OrdenActaPdf, A153OrdenActaPdf, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            pr_default.close(35);
            dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         }
      }

      protected void delete( )
      {
         BeforeValidate0H16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H16( ) ;
            AfterConfirm0H16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H16( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0H52( ) ;
                  while ( RcdFound52 != 0 )
                  {
                     getByPrimaryKey0H52( ) ;
                     Delete0H52( ) ;
                     ScanNext0H52( ) ;
                  }
                  ScanEnd0H52( ) ;
                  A210OrdenUltSec = O210OrdenUltSec;
                  n210OrdenUltSec = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                  ScanStart0H17( ) ;
                  while ( RcdFound17 != 0 )
                  {
                     getByPrimaryKey0H17( ) ;
                     Delete0H17( ) ;
                     ScanNext0H17( ) ;
                     O210OrdenUltSec = A210OrdenUltSec;
                     n210OrdenUltSec = false;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
                  }
                  ScanEnd0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H41 */
                     pr_default.execute(36, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
                     pr_default.close(36);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
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
         sMode16 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0H16( ) ;
         Gx_mode = sMode16;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0H16( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV46Pgmname = "OrdenProduccion";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46Pgmname", AV46Pgmname);
            /* Using cursor T000H42 */
            pr_default.execute(37, new Object[] {A1EmpID});
            A44empdsc = T000H42_A44empdsc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
            n44empdsc = T000H42_n44empdsc[0];
            pr_default.close(37);
            /* Using cursor T000H43 */
            pr_default.execute(38, new Object[] {A1EmpID, A5ClienteID});
            A57ClienteDsc = T000H43_A57ClienteDsc[0];
            n57ClienteDsc = T000H43_n57ClienteDsc[0];
            pr_default.close(38);
            if ( A5ClienteID == 9999 )
            {
               edtOrdenFacNomb_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Visible), 5, 0)), true);
            }
            /* Using cursor T000H45 */
            pr_default.execute(39, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            if ( (pr_default.getStatus(39) != 101) )
            {
               A255OrdenObreSuma = T000H45_A255OrdenObreSuma[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
               n255OrdenObreSuma = T000H45_n255OrdenObreSuma[0];
            }
            else
            {
               A255OrdenObreSuma = 0;
               n255OrdenObreSuma = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
            }
            pr_default.close(39);
            /* Using cursor T000H46 */
            pr_default.execute(40, new Object[] {A1EmpID, A8VehiculoID});
            A68VehiculoPlaca = T000H46_A68VehiculoPlaca[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
            n68VehiculoPlaca = T000H46_n68VehiculoPlaca[0];
            A69VehiculoChasis = T000H46_A69VehiculoChasis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
            n69VehiculoChasis = T000H46_n69VehiculoChasis[0];
            pr_default.close(40);
            AV22MarcaID = A26OrdenMarcaID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
            GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
            /* Using cursor T000H47 */
            pr_default.execute(41, new Object[] {A1EmpID, A17tipOrdID});
            A104tipOrdDsc = T000H47_A104tipOrdDsc[0];
            n104tipOrdDsc = T000H47_n104tipOrdDsc[0];
            pr_default.close(41);
            /* Using cursor T000H48 */
            pr_default.execute(42, new Object[] {A1EmpID, A9vendedorID});
            A72vendedorDsc = T000H48_A72vendedorDsc[0];
            n72vendedorDsc = T000H48_n72vendedorDsc[0];
            pr_default.close(42);
            /* Using cursor T000H49 */
            pr_default.execute(43, new Object[] {A1EmpID, A10protID});
            A74protDsc = T000H49_A74protDsc[0];
            n74protDsc = T000H49_n74protDsc[0];
            pr_default.close(43);
            if ( StringUtil.StrCmp(A133OrdenProceso, "ENT") == 0 )
            {
               edtOrdenfchEnt_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Visible), 5, 0)), true);
            }
            A164OrdenValMatPri = NumberUtil.Round( (A162OrdenValInds+A163OrdenValEnrq+A165OrdenValCal), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164OrdenValMatPri", StringUtil.LTrim( StringUtil.Str( A164OrdenValMatPri, 10, 3)));
            A169OrdenValManObr = NumberUtil.Round( (A166OrdenValPint+A167OrdenValEstr+A168OrdenValOtrs), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169OrdenValManObr", StringUtil.LTrim( StringUtil.Str( A169OrdenValManObr, 10, 3)));
            A170OrdenTotGast = NumberUtil.Round( (A164OrdenValMatPri+A169OrdenValManObr), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170OrdenTotGast", StringUtil.LTrim( StringUtil.Str( A170OrdenTotGast, 10, 3)));
            A171OrdenValRenta = NumberUtil.Round( (A161OrdenSubtotal-A170OrdenTotGast), 2);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171OrdenValRenta", StringUtil.LTrim( StringUtil.Str( A171OrdenValRenta, 10, 3)));
         }
      }

      protected void ProcessNestedLevel0H52( )
      {
         nGXsfl_261_idx = 0;
         while ( nGXsfl_261_idx < nRC_GXsfl_261 )
         {
            ReadRow0H52( ) ;
            if ( ( nRcdExists_52 != 0 ) || ( nIsMod_52 != 0 ) )
            {
               standaloneNotModal0H52( ) ;
               GetKey0H52( ) ;
               if ( ( nRcdExists_52 == 0 ) && ( nRcdDeleted_52 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0H52( ) ;
               }
               else
               {
                  if ( RcdFound52 != 0 )
                  {
                     if ( ( nRcdDeleted_52 != 0 ) && ( nRcdExists_52 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0H52( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_52 != 0 ) && ( nRcdExists_52 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0H52( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_52 == 0 )
                     {
                        GXCCtl = "ORDENOBRID_" + sGXsfl_261_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtOrdenObrID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtOrdenObrID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A252OrdenObrID), 4, 0, ",", ""))) ;
            ChangePostValue( dynObreID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A238ObreID), 4, 0, ".", ""))) ;
            ChangePostValue( edtOrdenObreManObra_Internalname, A253OrdenObreManObra) ;
            ChangePostValue( edtOrdenObreValor_Internalname, StringUtil.LTrim( StringUtil.NToC( A254OrdenObreValor, 10, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z252OrdenObrID_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z252OrdenObrID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z238ObreID_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z238ObreID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z253OrdenObreManObra_"+sGXsfl_261_idx, Z253OrdenObreManObra) ;
            ChangePostValue( "ZT_"+"Z254OrdenObreValor_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( Z254OrdenObreValor, 10, 2, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_52_"+sGXsfl_261_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ",", ""))) ;
            if ( nIsMod_52 != 0 )
            {
               ChangePostValue( "ORDENOBRID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObrID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBREID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynObreID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENOBREMANOBRA_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreManObra_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENOBREVALOR_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreValor_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0H52( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_52 = 0;
         nIsMod_52 = 0;
         nRcdDeleted_52 = 0;
      }

      protected void ProcessNestedLevel0H17( )
      {
         s210OrdenUltSec = O210OrdenUltSec;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         nGXsfl_216_idx = 0;
         while ( nGXsfl_216_idx < nRC_GXsfl_216 )
         {
            ReadRow0H17( ) ;
            if ( ( nRcdExists_17 != 0 ) || ( nIsMod_17 != 0 ) )
            {
               standaloneNotModal0H17( ) ;
               GetKey0H17( ) ;
               if ( ( nRcdExists_17 == 0 ) && ( nRcdDeleted_17 == 0 ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0H17( ) ;
               }
               else
               {
                  if ( RcdFound17 != 0 )
                  {
                     if ( ( nRcdDeleted_17 != 0 ) && ( nRcdExists_17 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0H17( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_17 != 0 ) && ( nRcdExists_17 != 0 ) )
                        {
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0H17( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_17 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ORDENANIO");
                        AnyError = 1;
                        GX_FocusControl = edtOrdenAnio_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O210OrdenUltSec = A210OrdenUltSec;
               n210OrdenUltSec = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
            }
            ChangePostValue( edtOrdenSecId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41OrdenSecId), 4, 0, ",", ""))) ;
            ChangePostValue( dyndetTipoProdID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A36detTipoProdID), 4, 0, ".", ""))) ;
            ChangePostValue( dyncategID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32categID), 4, 0, ".", ""))) ;
            ChangePostValue( edtcategDsc_Internalname, StringUtil.RTrim( A146categDsc)) ;
            ChangePostValue( edtsubCatID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( edtsubCatDsc_Internalname, StringUtil.RTrim( A148subCatDsc)) ;
            ChangePostValue( chkOrdenDetDesp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A396OrdenDetDesp), 1, 0, ",", ""))) ;
            ChangePostValue( edtsubCatPrec_Internalname, StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetCant_Internalname, StringUtil.LTrim( StringUtil.NToC( A208OrdenDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetVal_Internalname, StringUtil.LTrim( StringUtil.NToC( A209OrdenDetVal, 8, 2, ",", ""))) ;
            ChangePostValue( edtOrdenDetDetalle_Internalname, A251OrdenDetDetalle) ;
            ChangePostValue( edtOrdenDesp_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A397OrdenDesp), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z41OrdenSecId_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41OrdenSecId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z208OrdenDetCant_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( Z208OrdenDetCant, 8, 2, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z251OrdenDetDetalle_"+sGXsfl_216_idx, Z251OrdenDetDetalle) ;
            ChangePostValue( "ZT_"+"Z396OrdenDetDesp_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z396OrdenDetDesp), 1, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z397OrdenDesp_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z397OrdenDesp), 2, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z32categID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_17), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_17), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_17_"+sGXsfl_216_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_17), 4, 0, ",", ""))) ;
            if ( nIsMod_17 != 0 )
            {
               ChangePostValue( "ORDENSECID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenSecId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DETTIPOPRODID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyndetTipoProdID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyncategID.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "CATEGDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkOrdenDetDesp.Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SUBCATPREC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETCANT_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetCant_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETVAL_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetVal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDETDETALLE_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ORDENDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDesp_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0H17( ) ;
         if ( AnyError != 0 )
         {
            O210OrdenUltSec = s210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         nRcdExists_17 = 0;
         nIsMod_17 = 0;
         nRcdDeleted_17 = 0;
      }

      protected void ProcessLevel0H16( )
      {
         /* Save parent mode. */
         sMode16 = Gx_mode;
         ProcessNestedLevel0H52( ) ;
         ProcessNestedLevel0H17( ) ;
         if ( AnyError != 0 )
         {
            O210OrdenUltSec = s210OrdenUltSec;
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode16;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
         /* Using cursor T000H50 */
         pr_default.execute(44, new Object[] {n210OrdenUltSec, A210OrdenUltSec, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         pr_default.close(44);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
      }

      protected void EndLevel0H16( )
      {
         pr_default.close(8);
         if ( AnyError == 0 )
         {
            BeforeComplete0H16( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(37);
            pr_default.close(38);
            pr_default.close(40);
            pr_default.close(42);
            pr_default.close(43);
            pr_default.close(41);
            pr_default.close(39);
            pr_default.close(5);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.CommitDataStores("ordenproduccion",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(37);
            pr_default.close(38);
            pr_default.close(40);
            pr_default.close(42);
            pr_default.close(43);
            pr_default.close(41);
            pr_default.close(39);
            pr_default.close(5);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.RollbackDataStores("ordenproduccion",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0H16( )
      {
         /* Scan By routine */
         /* Using cursor T000H51 */
         pr_default.execute(45);
         RcdFound16 = 0;
         if ( (pr_default.getStatus(45) != 101) )
         {
            RcdFound16 = 1;
            A1EmpID = T000H51_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = T000H51_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A24OrdenPeriodo = T000H51_A24OrdenPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            A25OrdenAnio = T000H51_A25OrdenAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            A22OrdenID = T000H51_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H16( )
      {
         /* Scan next routine */
         pr_default.readNext(45);
         RcdFound16 = 0;
         if ( (pr_default.getStatus(45) != 101) )
         {
            RcdFound16 = 1;
            A1EmpID = T000H51_A1EmpID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
            A5ClienteID = T000H51_A5ClienteID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
            A24OrdenPeriodo = T000H51_A24OrdenPeriodo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
            A25OrdenAnio = T000H51_A25OrdenAnio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
            A22OrdenID = T000H51_A22OrdenID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
      }

      protected void ScanEnd0H16( )
      {
         pr_default.close(45);
      }

      protected void AfterConfirm0H16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H16( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H16( )
      {
         edtOrdenFch_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFch_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFch_Enabled), 5, 0)), true);
         dynavUsucod.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavUsucod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavUsucod.Enabled), 5, 0)), true);
         edtOrdenfchEnt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenfchEnt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenfchEnt_Enabled), 5, 0)), true);
         edtOrdenAnio_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenAnio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenAnio_Enabled), 5, 0)), true);
         cmbOrdenPeriodo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenPeriodo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenPeriodo.Enabled), 5, 0)), true);
         dynOrdenProceso.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenProceso_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenProceso.Enabled), 5, 0)), true);
         edtEmpID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpID_Enabled), 5, 0)), true);
         edtempdsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtempdsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtempdsc_Enabled), 5, 0)), true);
         chkavFacemp.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavFacemp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavFacemp.Enabled), 5, 0)), true);
         dynOrdenEmpFac.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenEmpFac_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenEmpFac.Enabled), 5, 0)), true);
         dynOrdenMarcaID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenMarcaID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenMarcaID.Enabled), 5, 0)), true);
         dynOrdenModeloID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynOrdenModeloID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynOrdenModeloID.Enabled), 5, 0)), true);
         dynClienteID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynClienteID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynClienteID.Enabled), 5, 0)), true);
         edtOrdenFacNomb_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenFacNomb_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenFacNomb_Enabled), 5, 0)), true);
         dynvendedorID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynvendedorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynvendedorID.Enabled), 5, 0)), true);
         edtOrdenID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenID_Enabled), 5, 0)), true);
         dyntipOrdID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyntipOrdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyntipOrdID.Enabled), 5, 0)), true);
         dynprotID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynprotID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynprotID.Enabled), 5, 0)), true);
         edtfacturaNro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfacturaNro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfacturaNro_Enabled), 5, 0)), true);
         edtrepresentane_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtrepresentane_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtrepresentane_Enabled), 5, 0)), true);
         edtVehiculoID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoID_Enabled), 5, 0)), true);
         edtVehiculoPlaca_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoPlaca_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoPlaca_Enabled), 5, 0)), true);
         edtVehiculoChasis_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVehiculoChasis_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVehiculoChasis_Enabled), 5, 0)), true);
         edtOrdenPdf_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenPdf_Enabled), 5, 0)), true);
         edtfchVenta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtfchVenta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtfchVenta_Enabled), 5, 0)), true);
         edtcantDias_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcantDias_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcantDias_Enabled), 5, 0)), true);
         edtOrdenActaPdf_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenActaPdf_Enabled), 5, 0)), true);
         edtOrdenSubtotal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenSubtotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenSubtotal_Enabled), 5, 0)), true);
         cmbOrdenEst.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbOrdenEst_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbOrdenEst.Enabled), 5, 0)), true);
         edtOrdenNroDesp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenNroDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenNroDesp_Enabled), 5, 0)), true);
         edtOrdenValInds_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenValInds_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenValInds_Enabled), 5, 0)), true);
         edtOrdenValEnrq_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenValEnrq_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenValEnrq_Enabled), 5, 0)), true);
         edtOrdenValCal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenValCal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenValCal_Enabled), 5, 0)), true);
         edtOrdenValMatPri_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenValMatPri_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenValMatPri_Enabled), 5, 0)), true);
         edtOrdenObreSuma_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObreSuma_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObreSuma_Enabled), 5, 0)), true);
         edtOrdenTotGast_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenTotGast_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenTotGast_Enabled), 5, 0)), true);
         edtOrdenValRenta_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenValRenta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenValRenta_Enabled), 5, 0)), true);
         edtavMarcaid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMarcaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMarcaid_Enabled), 5, 0)), true);
         edtavEmpid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEmpid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEmpid_Enabled), 5, 0)), true);
         edtavValuenro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavValuenro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavValuenro_Enabled), 5, 0)), true);
      }

      protected void ZM0H52( short GX_JID )
      {
         if ( ( GX_JID == 81 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z253OrdenObreManObra = T000H9_A253OrdenObreManObra[0];
               Z254OrdenObreValor = T000H9_A254OrdenObreValor[0];
            }
            else
            {
               Z253OrdenObreManObra = A253OrdenObreManObra;
               Z254OrdenObreValor = A254OrdenObreValor;
            }
         }
         if ( GX_JID == -81 )
         {
            Z5ClienteID = A5ClienteID;
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            Z252OrdenObrID = A252OrdenObrID;
            Z238ObreID = A238ObreID;
            Z253OrdenObreManObra = A253OrdenObreManObra;
            Z254OrdenObreValor = A254OrdenObreValor;
            Z1EmpID = A1EmpID;
         }
      }

      protected void standaloneNotModal0H52( )
      {
         GXAOBREID_html0H52( ) ;
      }

      protected void standaloneModal0H52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtOrdenObrID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObrID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObrID_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         }
         else
         {
            edtOrdenObrID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObrID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObrID_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            dynObreID.Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynObreID.Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         }
         else
         {
            dynObreID.Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynObreID.Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         }
      }

      protected void Load0H52( )
      {
         /* Using cursor T000H52 */
         pr_default.execute(46, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
         if ( (pr_default.getStatus(46) != 101) )
         {
            RcdFound52 = 1;
            A253OrdenObreManObra = T000H52_A253OrdenObreManObra[0];
            n253OrdenObreManObra = T000H52_n253OrdenObreManObra[0];
            A254OrdenObreValor = T000H52_A254OrdenObreValor[0];
            n254OrdenObreValor = T000H52_n254OrdenObreValor[0];
            ZM0H52( -81) ;
         }
         pr_default.close(46);
         OnLoadActions0H52( ) ;
      }

      protected void OnLoadActions0H52( )
      {
      }

      protected void CheckExtendedTable0H52( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0H52( ) ;
      }

      protected void CloseExtendedTableCursors0H52( )
      {
      }

      protected void enableDisable0H52( )
      {
      }

      protected void GetKey0H52( )
      {
         /* Using cursor T000H53 */
         pr_default.execute(47, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
         if ( (pr_default.getStatus(47) != 101) )
         {
            RcdFound52 = 1;
         }
         else
         {
            RcdFound52 = 0;
         }
         pr_default.close(47);
      }

      protected void getByPrimaryKey0H52( )
      {
         /* Using cursor T000H9 */
         pr_default.execute(7, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            ZM0H52( 81) ;
            RcdFound52 = 1;
            InitializeNonKey0H52( ) ;
            A252OrdenObrID = T000H9_A252OrdenObrID[0];
            A238ObreID = T000H9_A238ObreID[0];
            A253OrdenObreManObra = T000H9_A253OrdenObreManObra[0];
            n253OrdenObreManObra = T000H9_n253OrdenObreManObra[0];
            A254OrdenObreValor = T000H9_A254OrdenObreValor[0];
            n254OrdenObreValor = T000H9_n254OrdenObreValor[0];
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            Z252OrdenObrID = A252OrdenObrID;
            Z238ObreID = A238ObreID;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0H52( ) ;
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound52 = 0;
            InitializeNonKey0H52( ) ;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0H52( ) ;
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0H52( ) ;
         }
         pr_default.close(7);
      }

      protected void CheckOptimisticConcurrency0H52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H8 */
            pr_default.execute(6, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccionObr"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z253OrdenObreManObra, T000H8_A253OrdenObreManObra[0]) != 0 ) || ( Z254OrdenObreValor != T000H8_A254OrdenObreValor[0] ) )
            {
               if ( StringUtil.StrCmp(Z253OrdenObreManObra, T000H8_A253OrdenObreManObra[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenObreManObra");
                  GXUtil.WriteLogRaw("Old: ",Z253OrdenObreManObra);
                  GXUtil.WriteLogRaw("Current: ",T000H8_A253OrdenObreManObra[0]);
               }
               if ( Z254OrdenObreValor != T000H8_A254OrdenObreValor[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenObreValor");
                  GXUtil.WriteLogRaw("Old: ",Z254OrdenObreValor);
                  GXUtil.WriteLogRaw("Current: ",T000H8_A254OrdenObreValor[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenProduccionObr"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H52( )
      {
         BeforeValidate0H52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H52( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H52( 0) ;
            CheckOptimisticConcurrency0H52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H54 */
                     pr_default.execute(48, new Object[] {A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID, n253OrdenObreManObra, A253OrdenObreManObra, n254OrdenObreValor, A254OrdenObreValor, A1EmpID});
                     pr_default.close(48);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionObr") ;
                     if ( (pr_default.getStatus(48) == 1) )
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
               Load0H52( ) ;
            }
            EndLevel0H52( ) ;
         }
         CloseExtendedTableCursors0H52( ) ;
      }

      protected void Update0H52( )
      {
         BeforeValidate0H52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H52( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H55 */
                     pr_default.execute(49, new Object[] {n253OrdenObreManObra, A253OrdenObreManObra, n254OrdenObreValor, A254OrdenObreValor, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
                     pr_default.close(49);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionObr") ;
                     if ( (pr_default.getStatus(49) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccionObr"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H52( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0H52( ) ;
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
            EndLevel0H52( ) ;
         }
         CloseExtendedTableCursors0H52( ) ;
      }

      protected void DeferredUpdate0H52( )
      {
      }

      protected void Delete0H52( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0H52( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H52( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H52( ) ;
            AfterConfirm0H52( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H52( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000H56 */
                  pr_default.execute(50, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A252OrdenObrID, A238ObreID});
                  pr_default.close(50);
                  dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionObr") ;
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
         sMode52 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0H52( ) ;
         Gx_mode = sMode52;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0H52( )
      {
         standaloneModal0H52( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0H52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0H52( )
      {
         /* Scan By routine */
         /* Using cursor T000H57 */
         pr_default.execute(51, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         RcdFound52 = 0;
         if ( (pr_default.getStatus(51) != 101) )
         {
            RcdFound52 = 1;
            A252OrdenObrID = T000H57_A252OrdenObrID[0];
            A238ObreID = T000H57_A238ObreID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H52( )
      {
         /* Scan next routine */
         pr_default.readNext(51);
         RcdFound52 = 0;
         if ( (pr_default.getStatus(51) != 101) )
         {
            RcdFound52 = 1;
            A252OrdenObrID = T000H57_A252OrdenObrID[0];
            A238ObreID = T000H57_A238ObreID[0];
         }
      }

      protected void ScanEnd0H52( )
      {
         pr_default.close(51);
      }

      protected void AfterConfirm0H52( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H52( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H52( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H52( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H52( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H52( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H52( )
      {
         edtOrdenObrID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObrID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObrID_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         dynObreID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynObreID.Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         edtOrdenObreManObra_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObreManObra_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObreManObra_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         edtOrdenObreValor_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObreValor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObreValor_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
      }

      protected void send_integrity_lvl_hashes0H52( )
      {
      }

      protected void ZM0H17( short GX_JID )
      {
         if ( ( GX_JID == 82 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z208OrdenDetCant = T000H3_A208OrdenDetCant[0];
               Z251OrdenDetDetalle = T000H3_A251OrdenDetDetalle[0];
               Z396OrdenDetDesp = T000H3_A396OrdenDetDesp[0];
               Z397OrdenDesp = T000H3_A397OrdenDesp[0];
               Z36detTipoProdID = T000H3_A36detTipoProdID[0];
               Z32categID = T000H3_A32categID[0];
               Z33subCatID = T000H3_A33subCatID[0];
            }
            else
            {
               Z208OrdenDetCant = A208OrdenDetCant;
               Z251OrdenDetDetalle = A251OrdenDetDetalle;
               Z396OrdenDetDesp = A396OrdenDetDesp;
               Z397OrdenDesp = A397OrdenDesp;
               Z36detTipoProdID = A36detTipoProdID;
               Z32categID = A32categID;
               Z33subCatID = A33subCatID;
            }
         }
         if ( GX_JID == -82 )
         {
            Z5ClienteID = A5ClienteID;
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            Z41OrdenSecId = A41OrdenSecId;
            Z208OrdenDetCant = A208OrdenDetCant;
            Z251OrdenDetDetalle = A251OrdenDetDetalle;
            Z396OrdenDetDesp = A396OrdenDetDesp;
            Z397OrdenDesp = A397OrdenDesp;
            Z1EmpID = A1EmpID;
            Z36detTipoProdID = A36detTipoProdID;
            Z32categID = A32categID;
            Z33subCatID = A33subCatID;
            Z146categDsc = A146categDsc;
            Z148subCatDsc = A148subCatDsc;
            Z150subCatPrec = A150subCatPrec;
         }
      }

      protected void standaloneNotModal0H17( )
      {
         GXADETTIPOPRODID_html0H17( ) ;
         edtOrdenSecId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenSecId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenSecId_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtcategDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenDesp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDesp_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
      }

      protected void standaloneModal0H17( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A210OrdenUltSec = (short)(O210OrdenUltSec+1);
            n210OrdenUltSec = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A41OrdenSecId = A210OrdenUltSec;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
            /* Using cursor T000H5 */
            pr_default.execute(3, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000H5_A146categDsc[0];
            n146categDsc = T000H5_n146categDsc[0];
            pr_default.close(3);
         }
      }

      protected void Load0H17( )
      {
         /* Using cursor T000H58 */
         pr_default.execute(52, new Object[] {A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId, A1EmpID});
         if ( (pr_default.getStatus(52) != 101) )
         {
            RcdFound17 = 1;
            A146categDsc = T000H58_A146categDsc[0];
            n146categDsc = T000H58_n146categDsc[0];
            A148subCatDsc = T000H58_A148subCatDsc[0];
            n148subCatDsc = T000H58_n148subCatDsc[0];
            A150subCatPrec = T000H58_A150subCatPrec[0];
            n150subCatPrec = T000H58_n150subCatPrec[0];
            A208OrdenDetCant = T000H58_A208OrdenDetCant[0];
            n208OrdenDetCant = T000H58_n208OrdenDetCant[0];
            A251OrdenDetDetalle = T000H58_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = T000H58_n251OrdenDetDetalle[0];
            A396OrdenDetDesp = T000H58_A396OrdenDetDesp[0];
            n396OrdenDetDesp = T000H58_n396OrdenDetDesp[0];
            A397OrdenDesp = T000H58_A397OrdenDesp[0];
            n397OrdenDesp = T000H58_n397OrdenDesp[0];
            A36detTipoProdID = T000H58_A36detTipoProdID[0];
            A32categID = T000H58_A32categID[0];
            A33subCatID = T000H58_A33subCatID[0];
            ZM0H17( -82) ;
         }
         pr_default.close(52);
         OnLoadActions0H17( ) ;
      }

      protected void OnLoadActions0H17( )
      {
         A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
         GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
      }

      protected void CheckExtendedTable0H17( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal0H17( ) ;
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyndetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         /* Using cursor T000H5 */
         pr_default.execute(3, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000H5_A146categDsc[0];
         n146categDsc = T000H5_n146categDsc[0];
         pr_default.close(3);
         /* Using cursor T000H6 */
         pr_default.execute(4, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000H6_A148subCatDsc[0];
         n148subCatDsc = T000H6_n148subCatDsc[0];
         A150subCatPrec = T000H6_A150subCatPrec[0];
         n150subCatPrec = T000H6_n150subCatPrec[0];
         pr_default.close(4);
         A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
         GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
      }

      protected void CloseExtendedTableCursors0H17( )
      {
         pr_default.close(5);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable0H17( )
      {
      }

      protected void gxLoad_83( short A1EmpID ,
                                short A36detTipoProdID )
      {
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyndetTipoProdID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(2) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(2);
      }

      protected void gxLoad_84( short A1EmpID ,
                                short A32categID )
      {
         /* Using cursor T000H59 */
         pr_default.execute(53, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(53) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A146categDsc = T000H59_A146categDsc[0];
         n146categDsc = T000H59_n146categDsc[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A146categDsc))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(53) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(53);
      }

      protected void gxLoad_85( short A1EmpID ,
                                short A32categID ,
                                short A33subCatID )
      {
         /* Using cursor T000H60 */
         pr_default.execute(54, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(54) == 101) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_216_idx;
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A148subCatDsc = T000H60_A148subCatDsc[0];
         n148subCatDsc = T000H60_n148subCatDsc[0];
         A150subCatPrec = T000H60_A150subCatPrec[0];
         n150subCatPrec = T000H60_n150subCatPrec[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A148subCatDsc))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(54) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(54);
      }

      protected void GetKey0H17( )
      {
         /* Using cursor T000H61 */
         pr_default.execute(55, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
         if ( (pr_default.getStatus(55) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(55);
      }

      protected void getByPrimaryKey0H17( )
      {
         /* Using cursor T000H3 */
         pr_default.execute(1, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H17( 82) ;
            RcdFound17 = 1;
            InitializeNonKey0H17( ) ;
            A41OrdenSecId = T000H3_A41OrdenSecId[0];
            A208OrdenDetCant = T000H3_A208OrdenDetCant[0];
            n208OrdenDetCant = T000H3_n208OrdenDetCant[0];
            A251OrdenDetDetalle = T000H3_A251OrdenDetDetalle[0];
            n251OrdenDetDetalle = T000H3_n251OrdenDetDetalle[0];
            A396OrdenDetDesp = T000H3_A396OrdenDetDesp[0];
            n396OrdenDetDesp = T000H3_n396OrdenDetDesp[0];
            A397OrdenDesp = T000H3_A397OrdenDesp[0];
            n397OrdenDesp = T000H3_n397OrdenDesp[0];
            A36detTipoProdID = T000H3_A36detTipoProdID[0];
            A32categID = T000H3_A32categID[0];
            A33subCatID = T000H3_A33subCatID[0];
            Z1EmpID = A1EmpID;
            Z5ClienteID = A5ClienteID;
            Z24OrdenPeriodo = A24OrdenPeriodo;
            Z25OrdenAnio = A25OrdenAnio;
            Z22OrdenID = A22OrdenID;
            Z41OrdenSecId = A41OrdenSecId;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0H17( ) ;
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0H17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0H17( ) ;
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0H17( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0H17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H2 */
            pr_default.execute(0, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccionOpItems"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z208OrdenDetCant != T000H2_A208OrdenDetCant[0] ) || ( StringUtil.StrCmp(Z251OrdenDetDetalle, T000H2_A251OrdenDetDetalle[0]) != 0 ) || ( Z396OrdenDetDesp != T000H2_A396OrdenDetDesp[0] ) || ( Z397OrdenDesp != T000H2_A397OrdenDesp[0] ) || ( Z36detTipoProdID != T000H2_A36detTipoProdID[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z32categID != T000H2_A32categID[0] ) || ( Z33subCatID != T000H2_A33subCatID[0] ) )
            {
               if ( Z208OrdenDetCant != T000H2_A208OrdenDetCant[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenDetCant");
                  GXUtil.WriteLogRaw("Old: ",Z208OrdenDetCant);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A208OrdenDetCant[0]);
               }
               if ( StringUtil.StrCmp(Z251OrdenDetDetalle, T000H2_A251OrdenDetDetalle[0]) != 0 )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenDetDetalle");
                  GXUtil.WriteLogRaw("Old: ",Z251OrdenDetDetalle);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A251OrdenDetDetalle[0]);
               }
               if ( Z396OrdenDetDesp != T000H2_A396OrdenDetDesp[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenDetDesp");
                  GXUtil.WriteLogRaw("Old: ",Z396OrdenDetDesp);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A396OrdenDetDesp[0]);
               }
               if ( Z397OrdenDesp != T000H2_A397OrdenDesp[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"OrdenDesp");
                  GXUtil.WriteLogRaw("Old: ",Z397OrdenDesp);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A397OrdenDesp[0]);
               }
               if ( Z36detTipoProdID != T000H2_A36detTipoProdID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"detTipoProdID");
                  GXUtil.WriteLogRaw("Old: ",Z36detTipoProdID);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A36detTipoProdID[0]);
               }
               if ( Z32categID != T000H2_A32categID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"categID");
                  GXUtil.WriteLogRaw("Old: ",Z32categID);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A32categID[0]);
               }
               if ( Z33subCatID != T000H2_A33subCatID[0] )
               {
                  GXUtil.WriteLog("ordenproduccion:[seudo value changed for attri]"+"subCatID");
                  GXUtil.WriteLogRaw("Old: ",Z33subCatID);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A33subCatID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"OrdenProduccionOpItems"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H17( 0) ;
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H62 */
                     pr_default.execute(56, new Object[] {A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId, n208OrdenDetCant, A208OrdenDetCant, n251OrdenDetDetalle, A251OrdenDetDetalle, n396OrdenDetDesp, A396OrdenDetDesp, n397OrdenDesp, A397OrdenDesp, A1EmpID, A36detTipoProdID, A32categID, A33subCatID});
                     pr_default.close(56);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
                     if ( (pr_default.getStatus(56) == 1) )
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
               Load0H17( ) ;
            }
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void Update0H17( )
      {
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000H63 */
                     pr_default.execute(57, new Object[] {n208OrdenDetCant, A208OrdenDetCant, n251OrdenDetDetalle, A251OrdenDetDetalle, n396OrdenDetDesp, A396OrdenDetDesp, n397OrdenDesp, A397OrdenDesp, A36detTipoProdID, A32categID, A33subCatID, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
                     pr_default.close(57);
                     dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
                     if ( (pr_default.getStatus(57) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"OrdenProduccionOpItems"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H17( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0H17( ) ;
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
            EndLevel0H17( ) ;
         }
         CloseExtendedTableCursors0H17( ) ;
      }

      protected void DeferredUpdate0H17( )
      {
      }

      protected void Delete0H17( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0H17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H17( ) ;
            AfterConfirm0H17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000H64 */
                  pr_default.execute(58, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A41OrdenSecId});
                  pr_default.close(58);
                  dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0H17( ) ;
         Gx_mode = sMode17;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0H17( )
      {
         standaloneModal0H17( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
            /* Using cursor T000H65 */
            pr_default.execute(59, new Object[] {A1EmpID, A32categID});
            A146categDsc = T000H65_A146categDsc[0];
            n146categDsc = T000H65_n146categDsc[0];
            pr_default.close(59);
            /* Using cursor T000H66 */
            pr_default.execute(60, new Object[] {A1EmpID, A32categID, A33subCatID});
            A148subCatDsc = T000H66_A148subCatDsc[0];
            n148subCatDsc = T000H66_n148subCatDsc[0];
            A150subCatPrec = T000H66_A150subCatPrec[0];
            n150subCatPrec = T000H66_n150subCatPrec[0];
            pr_default.close(60);
            A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
         }
      }

      protected void EndLevel0H17( )
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

      public void ScanStart0H17( )
      {
         /* Scan By routine */
         /* Using cursor T000H67 */
         pr_default.execute(61, new Object[] {A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID, A1EmpID});
         RcdFound17 = 0;
         if ( (pr_default.getStatus(61) != 101) )
         {
            RcdFound17 = 1;
            A41OrdenSecId = T000H67_A41OrdenSecId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H17( )
      {
         /* Scan next routine */
         pr_default.readNext(61);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(61) != 101) )
         {
            RcdFound17 = 1;
            A41OrdenSecId = T000H67_A41OrdenSecId[0];
         }
      }

      protected void ScanEnd0H17( )
      {
         pr_default.close(61);
      }

      protected void AfterConfirm0H17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H17( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0H17( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0H17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H17( )
      {
         edtOrdenSecId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenSecId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenSecId_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         dyndetTipoProdID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyndetTipoProdID.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         dyncategID.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dyncategID.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtcategDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtsubCatID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatID_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtsubCatDsc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         chkOrdenDetDesp.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkOrdenDetDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkOrdenDetDesp.Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtsubCatPrec_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtsubCatPrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtsubCatPrec_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenDetCant_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetCant_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetCant_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenDetVal_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetVal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetVal_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenDetDetalle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDetDetalle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenDesp_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDesp_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
      }

      protected void send_integrity_lvl_hashes0H17( )
      {
      }

      protected void send_integrity_lvl_hashes0H16( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
      }

      protected void SubsflControlProps_26152( )
      {
         edtOrdenObrID_Internalname = "ORDENOBRID_"+sGXsfl_261_idx;
         dynObreID_Internalname = "OBREID_"+sGXsfl_261_idx;
         edtOrdenObreManObra_Internalname = "ORDENOBREMANOBRA_"+sGXsfl_261_idx;
         edtOrdenObreValor_Internalname = "ORDENOBREVALOR_"+sGXsfl_261_idx;
      }

      protected void SubsflControlProps_fel_26152( )
      {
         edtOrdenObrID_Internalname = "ORDENOBRID_"+sGXsfl_261_fel_idx;
         dynObreID_Internalname = "OBREID_"+sGXsfl_261_fel_idx;
         edtOrdenObreManObra_Internalname = "ORDENOBREMANOBRA_"+sGXsfl_261_fel_idx;
         edtOrdenObreValor_Internalname = "ORDENOBREVALOR_"+sGXsfl_261_fel_idx;
      }

      protected void AddRow0H52( )
      {
         nGXsfl_261_idx = (short)(nGXsfl_261_idx+1);
         sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx), 4, 0)), 4, "0");
         SubsflControlProps_26152( ) ;
         SendRow0H52( ) ;
      }

      protected void SendRow0H52( )
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
            if ( ((int)(((nGXsfl_261_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_261_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 262,'',false,'" + sGXsfl_261_idx + "',261)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenObrID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A252OrdenObrID), 4, 0, ",", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A252OrdenObrID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,262);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenObrID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtOrdenObrID_Enabled,(short)1,(String)"number",(String)"1",(short)65,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)261,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         GXAOBREID_html0H52( ) ;
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_261_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 263,'',false,'" + sGXsfl_261_idx + "',261)\"";
         GXCCtl = "OBREID_" + sGXsfl_261_idx;
         dynObreID.Name = GXCCtl;
         dynObreID.WebTags = "";
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynObreID,(String)dynObreID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A238ObreID), 4, 0)),(short)1,(String)dynObreID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,dynObreID.Enabled,(short)1,(short)0,(short)325,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,263);\"",(String)"",(bool)true});
         dynObreID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A238ObreID), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Values", (String)(dynObreID.ToJavascriptSource()), !bGXsfl_261_Refreshing);
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_261_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 264,'',false,'" + sGXsfl_261_idx + "',261)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenObreManObra_Internalname,(String)A253OrdenObreManObra,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,264);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenObreManObra_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtOrdenObreManObra_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)50,(short)0,(short)0,(short)261,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_52_" + sGXsfl_261_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 265,'',false,'" + sGXsfl_261_idx + "',261)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenObreValor_Internalname,StringUtil.LTrim( StringUtil.NToC( A254OrdenObreValor, 10, 2, ",", "")),((edtOrdenObreValor_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A254OrdenObreValor, "ZZZZZZ9.99")) : context.localUtil.Format( A254OrdenObreValor, "ZZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,265);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenObreValor_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtOrdenObreValor_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)261,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes0H52( ) ;
         GXCCtl = "Z252OrdenObrID_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z252OrdenObrID), 4, 0, ",", "")));
         GXCCtl = "Z238ObreID_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z238ObreID), 4, 0, ",", "")));
         GXCCtl = "Z253OrdenObreManObra_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z253OrdenObreManObra);
         GXCCtl = "Z254OrdenObreValor_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z254OrdenObreValor, 10, 2, ",", "")));
         GXCCtl = "nRcdDeleted_52_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_52), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_52_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_52), 4, 0, ",", "")));
         GXCCtl = "nIsMod_52_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_52), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_261_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV29TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV29TrnContext);
         }
         GXCCtl = "vAGEID_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ageID), 4, 0, ",", "")));
         GXCCtl = "vORDENANIO_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25OrdenAnio), 4, 0, ",", "")));
         GXCCtl = "vORDENPERIODO_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27OrdenPeriodo), 2, 0, ",", "")));
         GXCCtl = "vCLIENTEID_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ClienteID), 4, 0, ",", "")));
         GXCCtl = "vORDENID_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26OrdenID), 4, 0, ",", "")));
         GXCCtl = "vERRORMESSAGE_" + sGXsfl_261_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, AV37ErrorMessage);
         GxWebStd.gx_hidden_field( context, "ORDENOBRID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObrID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OBREID_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dynObreID.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENOBREMANOBRA_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreManObra_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENOBREVALOR_"+sGXsfl_261_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenObreValor_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow0H52( )
      {
         nGXsfl_261_idx = (short)(nGXsfl_261_idx+1);
         sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx), 4, 0)), 4, "0");
         SubsflControlProps_26152( ) ;
         edtOrdenObrID_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBRID_"+sGXsfl_261_idx+"Enabled"), ",", "."));
         dynObreID.Enabled = (int)(context.localUtil.CToN( cgiGet( "OBREID_"+sGXsfl_261_idx+"Enabled"), ",", "."));
         edtOrdenObreManObra_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBREMANOBRA_"+sGXsfl_261_idx+"Enabled"), ",", "."));
         edtOrdenObreValor_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENOBREVALOR_"+sGXsfl_261_idx+"Enabled"), ",", "."));
         if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenObrID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenObrID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "ORDENOBRID_" + sGXsfl_261_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtOrdenObrID_Internalname;
            wbErr = true;
            A252OrdenObrID = 0;
         }
         else
         {
            A252OrdenObrID = (short)(context.localUtil.CToN( cgiGet( edtOrdenObrID_Internalname), ",", "."));
         }
         dynObreID.Name = dynObreID_Internalname;
         dynObreID.CurrentValue = cgiGet( dynObreID_Internalname);
         A238ObreID = (short)(NumberUtil.Val( cgiGet( dynObreID_Internalname), "."));
         A253OrdenObreManObra = cgiGet( edtOrdenObreManObra_Internalname);
         n253OrdenObreManObra = false;
         n253OrdenObreManObra = (String.IsNullOrEmpty(StringUtil.RTrim( A253OrdenObreManObra)) ? true : false);
         if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenObreValor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenObreValor_Internalname), ",", ".") > 9999999.99m ) ) )
         {
            GXCCtl = "ORDENOBREVALOR_" + sGXsfl_261_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtOrdenObreValor_Internalname;
            wbErr = true;
            A254OrdenObreValor = 0;
            n254OrdenObreValor = false;
         }
         else
         {
            A254OrdenObreValor = context.localUtil.CToN( cgiGet( edtOrdenObreValor_Internalname), ",", ".");
            n254OrdenObreValor = false;
         }
         n254OrdenObreValor = ((Convert.ToDecimal(0)==A254OrdenObreValor) ? true : false);
         GXCCtl = "Z252OrdenObrID_" + sGXsfl_261_idx;
         Z252OrdenObrID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z238ObreID_" + sGXsfl_261_idx;
         Z238ObreID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z253OrdenObreManObra_" + sGXsfl_261_idx;
         Z253OrdenObreManObra = cgiGet( GXCCtl);
         n253OrdenObreManObra = (String.IsNullOrEmpty(StringUtil.RTrim( A253OrdenObreManObra)) ? true : false);
         GXCCtl = "Z254OrdenObreValor_" + sGXsfl_261_idx;
         Z254OrdenObreValor = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n254OrdenObreValor = ((Convert.ToDecimal(0)==A254OrdenObreValor) ? true : false);
         GXCCtl = "nRcdDeleted_52_" + sGXsfl_261_idx;
         nRcdDeleted_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_52_" + sGXsfl_261_idx;
         nRcdExists_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_52_" + sGXsfl_261_idx;
         nIsMod_52 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void SubsflControlProps_21617( )
      {
         edtOrdenSecId_Internalname = "ORDENSECID_"+sGXsfl_216_idx;
         dyndetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_216_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_216_idx;
         dyncategID_Internalname = "CATEGID_"+sGXsfl_216_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_216_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_216_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_216_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_216_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_216_idx;
         chkOrdenDetDesp_Internalname = "ORDENDETDESP_"+sGXsfl_216_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_216_idx;
         edtOrdenDetCant_Internalname = "ORDENDETCANT_"+sGXsfl_216_idx;
         edtOrdenDetVal_Internalname = "ORDENDETVAL_"+sGXsfl_216_idx;
         edtOrdenDetDetalle_Internalname = "ORDENDETDETALLE_"+sGXsfl_216_idx;
         edtOrdenDesp_Internalname = "ORDENDESP_"+sGXsfl_216_idx;
      }

      protected void SubsflControlProps_fel_21617( )
      {
         edtOrdenSecId_Internalname = "ORDENSECID_"+sGXsfl_216_fel_idx;
         dyndetTipoProdID_Internalname = "DETTIPOPRODID_"+sGXsfl_216_fel_idx;
         imgprompt_36_Internalname = "PROMPT_36_"+sGXsfl_216_fel_idx;
         dyncategID_Internalname = "CATEGID_"+sGXsfl_216_fel_idx;
         imgprompt_32_Internalname = "PROMPT_32_"+sGXsfl_216_fel_idx;
         edtcategDsc_Internalname = "CATEGDSC_"+sGXsfl_216_fel_idx;
         edtsubCatID_Internalname = "SUBCATID_"+sGXsfl_216_fel_idx;
         imgprompt_33_Internalname = "PROMPT_33_"+sGXsfl_216_fel_idx;
         edtsubCatDsc_Internalname = "SUBCATDSC_"+sGXsfl_216_fel_idx;
         chkOrdenDetDesp_Internalname = "ORDENDETDESP_"+sGXsfl_216_fel_idx;
         edtsubCatPrec_Internalname = "SUBCATPREC_"+sGXsfl_216_fel_idx;
         edtOrdenDetCant_Internalname = "ORDENDETCANT_"+sGXsfl_216_fel_idx;
         edtOrdenDetVal_Internalname = "ORDENDETVAL_"+sGXsfl_216_fel_idx;
         edtOrdenDetDetalle_Internalname = "ORDENDETDETALLE_"+sGXsfl_216_fel_idx;
         edtOrdenDesp_Internalname = "ORDENDESP_"+sGXsfl_216_fel_idx;
      }

      protected void AddRow0H17( )
      {
         nGXsfl_216_idx = (short)(nGXsfl_216_idx+1);
         sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx), 4, 0)), 4, "0");
         SubsflControlProps_21617( ) ;
         SendRow0H17( ) ;
      }

      protected void SendRow0H17( )
      {
         GriditemsopRow = GXWebRow.GetNew(context);
         if ( subGriditemsop_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGriditemsop_Backstyle = 0;
            if ( StringUtil.StrCmp(subGriditemsop_Class, "") != 0 )
            {
               subGriditemsop_Linesclass = subGriditemsop_Class+"Odd";
            }
         }
         else if ( subGriditemsop_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGriditemsop_Backstyle = 0;
            subGriditemsop_Backcolor = subGriditemsop_Allbackcolor;
            if ( StringUtil.StrCmp(subGriditemsop_Class, "") != 0 )
            {
               subGriditemsop_Linesclass = subGriditemsop_Class+"Uniform";
            }
         }
         else if ( subGriditemsop_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGriditemsop_Backstyle = 1;
            if ( StringUtil.StrCmp(subGriditemsop_Class, "") != 0 )
            {
               subGriditemsop_Linesclass = subGriditemsop_Class+"Odd";
            }
            subGriditemsop_Backcolor = (int)(0x0);
         }
         else if ( subGriditemsop_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGriditemsop_Backstyle = 1;
            if ( ((int)(((nGXsfl_216_idx-1)/ (decimal)(1)) % (2))) == 0 )
            {
               subGriditemsop_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriditemsop_Class, "") != 0 )
               {
                  subGriditemsop_Linesclass = subGriditemsop_Class+"Odd";
               }
            }
            else
            {
               subGriditemsop_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGriditemsop_Class, "") != 0 )
               {
                  subGriditemsop_Linesclass = subGriditemsop_Class+"Even";
               }
            }
         }
         imgprompt_33_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r2.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_216_idx+"'), id:'"+"CATEGID_"+sGXsfl_216_idx+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"SUBCATID_"+sGXsfl_216_idx+"'), id:'"+"SUBCATID_"+sGXsfl_216_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_17_"+sGXsfl_216_idx+","+"'', false"+","+"false"+");");
         imgprompt_32_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00q1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"CATEGID_"+sGXsfl_216_idx+"'), id:'"+"CATEGID_"+sGXsfl_216_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_17_"+sGXsfl_216_idx+","+"'', false"+","+"false"+");");
         imgprompt_36_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00p1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"EMPID"+"'), id:'"+"EMPID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"DETTIPOPRODID_"+sGXsfl_216_idx+"'), id:'"+"DETTIPOPRODID_"+sGXsfl_216_idx+"'"+",IOType:'out'}"+"],"+"gx.dom.form()."+"nIsMod_17_"+sGXsfl_216_idx+","+"'', false"+","+"false"+");");
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenSecId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A41OrdenSecId), 4, 0, ",", "")),((edtOrdenSecId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")) : context.localUtil.Format( (decimal)(A41OrdenSecId), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenSecId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtOrdenSecId_Enabled,(short)0,(String)"number",(String)"1",(short)50,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         GXADETTIPOPRODID_html0H17( ) ;
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 218,'',false,'" + sGXsfl_216_idx + "',216)\"";
         if ( ( dyndetTipoProdID.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "DETTIPOPRODID_" + sGXsfl_216_idx;
            dyndetTipoProdID.Name = GXCCtl;
            dyndetTipoProdID.WebTags = "";
         }
         /* ComboBox */
         GriditemsopRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dyndetTipoProdID,(String)dyndetTipoProdID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0)),(short)1,(String)dyndetTipoProdID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,dyndetTipoProdID.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,218);\"",(String)"",(bool)true});
         dyndetTipoProdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A36detTipoProdID), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyndetTipoProdID_Internalname, "Values", (String)(dyndetTipoProdID.ToJavascriptSource()), !bGXsfl_216_Refreshing);
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GriditemsopRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_36_Internalname,(String)sImgUrl,(String)imgprompt_36_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_36_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
         /* Subfile cell */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 219,'',false,'" + sGXsfl_216_idx + "',216)\"";
         if ( ( dyncategID.ItemCount == 0 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "CATEGID_" + sGXsfl_216_idx;
            dyncategID.Name = GXCCtl;
            dyncategID.WebTags = "";
         }
         /* ComboBox */
         GriditemsopRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dyncategID,(String)dyncategID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0)),(short)1,(String)dyncategID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,dyncategID.Enabled,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,219);\"",(String)"",(bool)true});
         dyncategID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A32categID), 4, 0));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dyncategID_Internalname, "Values", (String)(dyncategID.ToJavascriptSource()), !bGXsfl_216_Refreshing);
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GriditemsopRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_32_Internalname,(String)sImgUrl,(String)imgprompt_32_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_32_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtcategDsc_Internalname,StringUtil.RTrim( A146categDsc),StringUtil.RTrim( context.localUtil.Format( A146categDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtcategDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtcategDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 221,'',false,'" + sGXsfl_216_idx + "',216)\"";
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A33subCatID), 4, 0, ",", "")),((edtsubCatID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")) : context.localUtil.Format( (decimal)(A33subCatID), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,221);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatID_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GriditemsopRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_33_Internalname,(String)sImgUrl,(String)imgprompt_33_Link,(String)"",(String)"",context.GetTheme( ),(int)imgprompt_33_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)false,(bool)false,context.GetImageSrcSet( sImgUrl)});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatDsc_Internalname,StringUtil.RTrim( A148subCatDsc),StringUtil.RTrim( context.localUtil.Format( A148subCatDsc, "@!")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatDsc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatDsc_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)-1,(bool)true,(String)"nombres",(String)"left",(bool)true});
         /* Subfile cell */
         /* Check box */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 223,'',false,'" + sGXsfl_216_idx + "',216)\"";
         ClassString = "Attribute";
         StyleString = "";
         GriditemsopRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkOrdenDetDesp_Internalname,StringUtil.Str( (decimal)(A396OrdenDetDesp), 1, 0),(String)"",(String)"",(short)-1,chkOrdenDetDesp.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",TempTags+" onclick=\"gx.fn.checkboxClick(223, this, 1, 0);gx.evt.onchange(this, event);\" "});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtsubCatPrec_Internalname,StringUtil.LTrim( StringUtil.NToC( A150subCatPrec, 8, 2, ",", "")),((edtsubCatPrec_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")) : context.localUtil.Format( A150subCatPrec, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtsubCatPrec_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtsubCatPrec_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 225,'',false,'" + sGXsfl_216_idx + "',216)\"";
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenDetCant_Internalname,StringUtil.LTrim( StringUtil.NToC( A208OrdenDetCant, 8, 2, ",", "")),((edtOrdenDetCant_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A208OrdenDetCant, "ZZZZ9.99")) : context.localUtil.Format( A208OrdenDetCant, "ZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, '.',',','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,225);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenDetCant_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtOrdenDetCant_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenDetVal_Internalname,StringUtil.LTrim( StringUtil.NToC( A209OrdenDetVal, 8, 2, ",", "")),((edtOrdenDetVal_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A209OrdenDetVal, "ZZZZ9.99")) : context.localUtil.Format( A209OrdenDetVal, "ZZZZ9.99")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenDetVal_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtOrdenDetVal_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_17_" + sGXsfl_216_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 227,'',false,'" + sGXsfl_216_idx + "',216)\"";
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenDetDetalle_Internalname,(String)A251OrdenDetDetalle,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,227);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenDetDetalle_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtOrdenDetDetalle_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
         /* Subfile cell */
         /* Single line edit */
         ROClassString = "Attribute";
         GriditemsopRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtOrdenDesp_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A397OrdenDesp), 2, 0, ",", "")),((edtOrdenDesp_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A397OrdenDesp), "Z9")) : context.localUtil.Format( (decimal)(A397OrdenDesp), "Z9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtOrdenDesp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(int)edtOrdenDesp_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)216,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
         context.httpAjaxContext.ajax_sending_grid_row(GriditemsopRow);
         send_integrity_lvl_hashes0H17( ) ;
         GXCCtl = "Z41OrdenSecId_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41OrdenSecId), 4, 0, ",", "")));
         GXCCtl = "Z208OrdenDetCant_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z208OrdenDetCant, 8, 2, ",", "")));
         GXCCtl = "Z251OrdenDetDetalle_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, Z251OrdenDetDetalle);
         GXCCtl = "Z396OrdenDetDesp_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z396OrdenDetDesp), 1, 0, ",", "")));
         GXCCtl = "Z397OrdenDesp_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z397OrdenDesp), 2, 0, ",", "")));
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z36detTipoProdID), 4, 0, ",", "")));
         GXCCtl = "Z32categID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32categID), 4, 0, ",", "")));
         GXCCtl = "Z33subCatID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z33subCatID), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_17_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_17), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_17_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_17), 4, 0, ",", "")));
         GXCCtl = "nIsMod_17_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_17), 4, 0, ",", "")));
         GXCCtl = "vMODE_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_216_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV29TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV29TrnContext);
         }
         GXCCtl = "vAGEID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ageID), 4, 0, ",", "")));
         GXCCtl = "vORDENANIO_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25OrdenAnio), 4, 0, ",", "")));
         GXCCtl = "vORDENPERIODO_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27OrdenPeriodo), 2, 0, ",", "")));
         GXCCtl = "vCLIENTEID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ClienteID), 4, 0, ",", "")));
         GXCCtl = "vORDENID_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26OrdenID), 4, 0, ",", "")));
         GXCCtl = "vERRORMESSAGE_" + sGXsfl_216_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, AV37ErrorMessage);
         GxWebStd.gx_hidden_field( context, "ORDENSECID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenSecId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DETTIPOPRODID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyndetTipoProdID.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CATEGID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(dyncategID.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "CATEGDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtcategDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATID_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatID_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATDSC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatDsc_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENDETDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkOrdenDetDesp.Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SUBCATPREC_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtsubCatPrec_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENDETCANT_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetCant_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENDETVAL_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetVal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENDETDETALLE_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDetDetalle_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ORDENDESP_"+sGXsfl_216_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtOrdenDesp_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_36_"+sGXsfl_216_idx+"Link", StringUtil.RTrim( imgprompt_36_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_32_"+sGXsfl_216_idx+"Link", StringUtil.RTrim( imgprompt_32_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_33_"+sGXsfl_216_idx+"Link", StringUtil.RTrim( imgprompt_33_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         GriditemsopContainer.AddRow(GriditemsopRow);
      }

      protected void ReadRow0H17( )
      {
         nGXsfl_216_idx = (short)(nGXsfl_216_idx+1);
         sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx), 4, 0)), 4, "0");
         SubsflControlProps_21617( ) ;
         edtOrdenSecId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENSECID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         dyndetTipoProdID.Enabled = (int)(context.localUtil.CToN( cgiGet( "DETTIPOPRODID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         dyncategID.Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtcategDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "CATEGDSC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtsubCatID_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATID_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtsubCatDsc_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATDSC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         chkOrdenDetDesp.Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETDESP_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtsubCatPrec_Enabled = (int)(context.localUtil.CToN( cgiGet( "SUBCATPREC_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtOrdenDetCant_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETCANT_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtOrdenDetVal_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETVAL_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtOrdenDetDetalle_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDETDETALLE_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         edtOrdenDesp_Enabled = (int)(context.localUtil.CToN( cgiGet( "ORDENDESP_"+sGXsfl_216_idx+"Enabled"), ",", "."));
         imgprompt_1_Link = cgiGet( "PROMPT_36_"+sGXsfl_216_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_32_"+sGXsfl_216_idx+"Link");
         imgprompt_1_Link = cgiGet( "PROMPT_33_"+sGXsfl_216_idx+"Link");
         A41OrdenSecId = (short)(context.localUtil.CToN( cgiGet( edtOrdenSecId_Internalname), ",", "."));
         dyndetTipoProdID.Name = dyndetTipoProdID_Internalname;
         dyndetTipoProdID.CurrentValue = cgiGet( dyndetTipoProdID_Internalname);
         A36detTipoProdID = (short)(NumberUtil.Val( cgiGet( dyndetTipoProdID_Internalname), "."));
         dyncategID.Name = dyncategID_Internalname;
         dyncategID.CurrentValue = cgiGet( dyncategID_Internalname);
         A32categID = (short)(NumberUtil.Val( cgiGet( dyncategID_Internalname), "."));
         A146categDsc = StringUtil.Upper( cgiGet( edtcategDsc_Internalname));
         n146categDsc = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtsubCatID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SUBCATID_" + sGXsfl_216_idx;
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
         if ( ( ( ((StringUtil.StrCmp(cgiGet( chkOrdenDetDesp_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkOrdenDetDesp_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
         {
            GXCCtl = "ORDENDETDESP_" + sGXsfl_216_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = chkOrdenDetDesp_Internalname;
            wbErr = true;
            A396OrdenDetDesp = 0;
            n396OrdenDetDesp = false;
         }
         else
         {
            A396OrdenDetDesp = (short)(((StringUtil.StrCmp(cgiGet( chkOrdenDetDesp_Internalname), "1")==0) ? 1 : 0));
            n396OrdenDetDesp = false;
         }
         n396OrdenDetDesp = ((0==A396OrdenDetDesp) ? true : false);
         A150subCatPrec = context.localUtil.CToN( cgiGet( edtsubCatPrec_Internalname), ",", ".");
         n150subCatPrec = false;
         if ( ( ( context.localUtil.CToN( cgiGet( edtOrdenDetCant_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrdenDetCant_Internalname), ",", ".") > 99999.99m ) ) )
         {
            GXCCtl = "ORDENDETCANT_" + sGXsfl_216_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtOrdenDetCant_Internalname;
            wbErr = true;
            A208OrdenDetCant = 0;
            n208OrdenDetCant = false;
         }
         else
         {
            A208OrdenDetCant = context.localUtil.CToN( cgiGet( edtOrdenDetCant_Internalname), ",", ".");
            n208OrdenDetCant = false;
         }
         n208OrdenDetCant = ((Convert.ToDecimal(0)==A208OrdenDetCant) ? true : false);
         A209OrdenDetVal = context.localUtil.CToN( cgiGet( edtOrdenDetVal_Internalname), ",", ".");
         A251OrdenDetDetalle = cgiGet( edtOrdenDetDetalle_Internalname);
         n251OrdenDetDetalle = false;
         n251OrdenDetDetalle = (String.IsNullOrEmpty(StringUtil.RTrim( A251OrdenDetDetalle)) ? true : false);
         A397OrdenDesp = (short)(context.localUtil.CToN( cgiGet( edtOrdenDesp_Internalname), ",", "."));
         n397OrdenDesp = false;
         GXCCtl = "Z41OrdenSecId_" + sGXsfl_216_idx;
         Z41OrdenSecId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z208OrdenDetCant_" + sGXsfl_216_idx;
         Z208OrdenDetCant = context.localUtil.CToN( cgiGet( GXCCtl), ",", ".");
         n208OrdenDetCant = ((Convert.ToDecimal(0)==A208OrdenDetCant) ? true : false);
         GXCCtl = "Z251OrdenDetDetalle_" + sGXsfl_216_idx;
         Z251OrdenDetDetalle = cgiGet( GXCCtl);
         n251OrdenDetDetalle = (String.IsNullOrEmpty(StringUtil.RTrim( A251OrdenDetDetalle)) ? true : false);
         GXCCtl = "Z396OrdenDetDesp_" + sGXsfl_216_idx;
         Z396OrdenDetDesp = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n396OrdenDetDesp = ((0==A396OrdenDetDesp) ? true : false);
         GXCCtl = "Z397OrdenDesp_" + sGXsfl_216_idx;
         Z397OrdenDesp = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         n397OrdenDesp = ((0==A397OrdenDesp) ? true : false);
         GXCCtl = "Z36detTipoProdID_" + sGXsfl_216_idx;
         Z36detTipoProdID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z32categID_" + sGXsfl_216_idx;
         Z32categID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "Z33subCatID_" + sGXsfl_216_idx;
         Z33subCatID = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdDeleted_17_" + sGXsfl_216_idx;
         nRcdDeleted_17 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nRcdExists_17_" + sGXsfl_216_idx;
         nRcdExists_17 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
         GXCCtl = "nIsMod_17_" + sGXsfl_216_idx;
         nIsMod_17 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", "."));
      }

      protected void assign_properties_default( )
      {
         defdynObreID_Enabled = dynObreID.Enabled;
         defedtOrdenObrID_Enabled = edtOrdenObrID_Enabled;
         defedtOrdenDesp_Enabled = edtOrdenDesp_Enabled;
         defedtcategDsc_Enabled = edtcategDsc_Enabled;
         defedtOrdenSecId_Enabled = edtOrdenSecId_Enabled;
      }

      protected void ConfirmValues0H0( )
      {
         nGXsfl_216_idx = 0;
         sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx), 4, 0)), 4, "0");
         SubsflControlProps_21617( ) ;
         while ( nGXsfl_216_idx < nRC_GXsfl_216 )
         {
            nGXsfl_216_idx = (short)(nGXsfl_216_idx+1);
            sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx), 4, 0)), 4, "0");
            SubsflControlProps_21617( ) ;
            ChangePostValue( "Z41OrdenSecId_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z41OrdenSecId_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z41OrdenSecId_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z208OrdenDetCant_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z208OrdenDetCant_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z208OrdenDetCant_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z251OrdenDetDetalle_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z251OrdenDetDetalle_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z251OrdenDetDetalle_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z396OrdenDetDesp_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z396OrdenDetDesp_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z396OrdenDetDesp_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z397OrdenDesp_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z397OrdenDesp_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z397OrdenDesp_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z36detTipoProdID_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z36detTipoProdID_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z36detTipoProdID_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z32categID_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z32categID_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z32categID_"+sGXsfl_216_idx) ;
            ChangePostValue( "Z33subCatID_"+sGXsfl_216_idx, cgiGet( "ZT_"+"Z33subCatID_"+sGXsfl_216_idx)) ;
            DeletePostValue( "ZT_"+"Z33subCatID_"+sGXsfl_216_idx) ;
         }
         nGXsfl_261_idx = 0;
         sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx), 4, 0)), 4, "0");
         SubsflControlProps_26152( ) ;
         while ( nGXsfl_261_idx < nRC_GXsfl_261 )
         {
            nGXsfl_261_idx = (short)(nGXsfl_261_idx+1);
            sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx), 4, 0)), 4, "0");
            SubsflControlProps_26152( ) ;
            ChangePostValue( "Z252OrdenObrID_"+sGXsfl_261_idx, cgiGet( "ZT_"+"Z252OrdenObrID_"+sGXsfl_261_idx)) ;
            DeletePostValue( "ZT_"+"Z252OrdenObrID_"+sGXsfl_261_idx) ;
            ChangePostValue( "Z238ObreID_"+sGXsfl_261_idx, cgiGet( "ZT_"+"Z238ObreID_"+sGXsfl_261_idx)) ;
            DeletePostValue( "ZT_"+"Z238ObreID_"+sGXsfl_261_idx) ;
            ChangePostValue( "Z253OrdenObreManObra_"+sGXsfl_261_idx, cgiGet( "ZT_"+"Z253OrdenObreManObra_"+sGXsfl_261_idx)) ;
            DeletePostValue( "ZT_"+"Z253OrdenObreManObra_"+sGXsfl_261_idx) ;
            ChangePostValue( "Z254OrdenObreValor_"+sGXsfl_261_idx, cgiGet( "ZT_"+"Z254OrdenObreValor_"+sGXsfl_261_idx)) ;
            DeletePostValue( "ZT_"+"Z254OrdenObreValor_"+sGXsfl_261_idx) ;
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
         context.SendWebValue( "Orden Produccion") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20231170132535", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("ordenproduccion.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV10EmpID) + "," + UrlEncode("" +AV7ageID) + "," + UrlEncode("" +AV9ClienteID) + "," + UrlEncode("" +AV27OrdenPeriodo) + "," + UrlEncode("" +AV25OrdenAnio) + "," + UrlEncode("" +AV26OrdenID) + "," + UrlEncode(StringUtil.RTrim(AV33usuCod))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vUSUCOD", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV33usuCod, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "OrdenProduccion";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV19Insert_VehiculoID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV15Insert_OrdenMarcaID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV18Insert_tipOrdID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV20Insert_vendedorID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV17Insert_protID), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A116OrdenUser, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A203ordenNroPed), "ZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A166OrdenValPint, "ZZZZZ9.999");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A167OrdenValEstr, "ZZZZZ9.999");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A168OrdenValOtrs, "ZZZZZ9.999");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A192OrdenPed), "ZZZZZZZ9");
         AV11facEmp = (short)(((StringUtil.StrCmp(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11facEmp), 4, 0, ".", "")), "1")==0) ? 1 : 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV11facEmp), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV43ordenDesp), "Z9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Insert_VehiculoID:"+context.localUtil.Format( (decimal)(AV19Insert_VehiculoID), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Insert_OrdenMarcaID:"+context.localUtil.Format( (decimal)(AV15Insert_OrdenMarcaID), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Insert_tipOrdID:"+context.localUtil.Format( (decimal)(AV18Insert_tipOrdID), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Insert_vendedorID:"+context.localUtil.Format( (decimal)(AV20Insert_vendedorID), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Insert_protID:"+context.localUtil.Format( (decimal)(AV17Insert_protID), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"OrdenUser:"+StringUtil.RTrim( context.localUtil.Format( A116OrdenUser, "@!")));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"ordenNroPed:"+context.localUtil.Format( (decimal)(A203ordenNroPed), "ZZZZZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"OrdenValPint:"+context.localUtil.Format( A166OrdenValPint, "ZZZZZ9.999"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"OrdenValEstr:"+context.localUtil.Format( A167OrdenValEstr, "ZZZZZ9.999"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"OrdenValOtrs:"+context.localUtil.Format( A168OrdenValOtrs, "ZZZZZ9.999"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"OrdenPed:"+context.localUtil.Format( (decimal)(A192OrdenPed), "ZZZZZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"facEmp:"+context.localUtil.Format( (decimal)(AV11facEmp), "ZZZ9"));
         GXUtil.WriteLog("ordenproduccion:[SendSecurityCheck value for]"+"ordenDesp:"+context.localUtil.Format( (decimal)(AV43ordenDesp), "Z9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1EmpID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1EmpID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z5ClienteID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z5ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z24OrdenPeriodo", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z24OrdenPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z25OrdenAnio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z25OrdenAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z22OrdenID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z116OrdenUser", StringUtil.RTrim( Z116OrdenUser));
         GxWebStd.gx_hidden_field( context, "Z115OrdenEst", StringUtil.RTrim( Z115OrdenEst));
         GxWebStd.gx_hidden_field( context, "Z117OrdenModeloID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z117OrdenModeloID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z119OrdenFch", context.localUtil.DToC( Z119OrdenFch, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z106facturaNro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z106facturaNro), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z107representane", StringUtil.RTrim( Z107representane));
         GxWebStd.gx_hidden_field( context, "Z203ordenNroPed", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z203ordenNroPed), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z109fchVenta", context.localUtil.DToC( Z109fchVenta, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z110cantDias", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z110cantDias), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z132OrdenEmpFac", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z132OrdenEmpFac), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z133OrdenProceso", Z133OrdenProceso);
         GxWebStd.gx_hidden_field( context, "Z161OrdenSubtotal", StringUtil.LTrim( StringUtil.NToC( Z161OrdenSubtotal, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z162OrdenValInds", StringUtil.LTrim( StringUtil.NToC( Z162OrdenValInds, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z163OrdenValEnrq", StringUtil.LTrim( StringUtil.NToC( Z163OrdenValEnrq, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z165OrdenValCal", StringUtil.LTrim( StringUtil.NToC( Z165OrdenValCal, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z166OrdenValPint", StringUtil.LTrim( StringUtil.NToC( Z166OrdenValPint, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z167OrdenValEstr", StringUtil.LTrim( StringUtil.NToC( Z167OrdenValEstr, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z168OrdenValOtrs", StringUtil.LTrim( StringUtil.NToC( Z168OrdenValOtrs, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z172OrdenfchEnt", context.localUtil.DToC( Z172OrdenfchEnt, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z192OrdenPed", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z192OrdenPed), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z195OrdenFacNomb", StringUtil.RTrim( Z195OrdenFacNomb));
         GxWebStd.gx_hidden_field( context, "Z210OrdenUltSec", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z210OrdenUltSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z401OrdenNroDesp", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z401OrdenNroDesp), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z26OrdenMarcaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z26OrdenMarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z8VehiculoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z9vendedorID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9vendedorID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z10protID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z17tipOrdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17tipOrdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "O210OrdenUltSec", StringUtil.LTrim( StringUtil.NToC( (decimal)(O210OrdenUltSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_261", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_261_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_216", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_216_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N8VehiculoID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N26OrdenMarcaID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26OrdenMarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N17tipOrdID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17tipOrdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N9vendedorID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A9vendedorID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "N10protID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10protID), 4, 0, ",", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV29TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV29TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vAGEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ageID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vAGEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7ageID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vERRORMESSAGE", AV37ErrorMessage);
         GxWebStd.gx_hidden_field( context, "ORDENDESP", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43ordenDesp), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENVALMANOBR", StringUtil.LTrim( StringUtil.NToC( A169OrdenValManObr, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENVALPINT", StringUtil.LTrim( StringUtil.NToC( A166OrdenValPint, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENVALESTR", StringUtil.LTrim( StringUtil.NToC( A167OrdenValEstr, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENVALOTRS", StringUtil.LTrim( StringUtil.NToC( A168OrdenValOtrs, 10, 3, ",", "")));
         GxWebStd.gx_hidden_field( context, "vCLIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9ClienteID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vCLIENTEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV9ClienteID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vORDENPERIODO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27OrdenPeriodo), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENPERIODO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV27OrdenPeriodo), "Z9"), context));
         GxWebStd.gx_hidden_field( context, "vORDENANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25OrdenAnio), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vORDENID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26OrdenID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vORDENID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV26OrdenID), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_VEHICULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19Insert_VehiculoID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_ORDENMARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_OrdenMarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPORDID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18Insert_tipOrdID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_VENDEDORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20Insert_vendedorID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_PROTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17Insert_protID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENUSER", StringUtil.RTrim( A116OrdenUser));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vORDENDESP", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43ordenDesp), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENNROPED", StringUtil.LTrim( StringUtil.NToC( (decimal)(A203ordenNroPed), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "URLPDF", A108urlPdf);
         GxWebStd.gx_hidden_field( context, "DOCUMENTO", A112documento);
         GxWebStd.gx_hidden_field( context, "ORDENPED", StringUtil.LTrim( StringUtil.NToC( (decimal)(A192OrdenPed), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "ORDENULTSEC", StringUtil.LTrim( StringUtil.NToC( (decimal)(A210OrdenUltSec), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "CLIENTEDSC", StringUtil.RTrim( A57ClienteDsc));
         GxWebStd.gx_hidden_field( context, "VENDEDORDSC", StringUtil.RTrim( A72vendedorDsc));
         GxWebStd.gx_hidden_field( context, "PROTDSC", StringUtil.RTrim( A74protDsc));
         GxWebStd.gx_hidden_field( context, "TIPORDDSC", StringUtil.RTrim( A104tipOrdDsc));
         GxWebStd.gx_hidden_field( context, "MARCAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6MarcaID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV46Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "OBREPRAPELLIDO", A242ObrePrApellido);
         GxWebStd.gx_hidden_field( context, "OBRESEGAPELLIDO", A243ObreSegApellido);
         GxWebStd.gx_hidden_field( context, "OBREPRNOMBRE", A240ObrePrNombre);
         GxWebStd.gx_hidden_field( context, "OBRESEGNOMBRE", A241ObreSegNombre);
         GxWebStd.gx_hidden_field( context, "OBRENOMBRE", A244ObreNombre);
         GxWebStd.gx_hidden_field( context, "TIPOPRODID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31tipoProdID), 4, 0, ",", "")));
         GXCCtlgxBlob = "ORDENPDF" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A152OrdenPdf);
         GXCCtlgxBlob = "ORDENACTAPDF" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A153OrdenActaPdf);
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Objectcall", StringUtil.RTrim( Tabcosteo_Objectcall));
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Enabled", StringUtil.BoolToStr( Tabcosteo_Enabled));
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Class", StringUtil.RTrim( Tabcosteo_Class));
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabcosteo_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Historymanagement", StringUtil.BoolToStr( Tabcosteo_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TABCOSTEO_Visible", StringUtil.BoolToStr( Tabcosteo_Visible));
         GxWebStd.gx_hidden_field( context, "ORDENPDF_Filename", StringUtil.RTrim( edtOrdenPdf_Filename));
         GxWebStd.gx_hidden_field( context, "ORDENACTAPDF_Filename", StringUtil.RTrim( edtOrdenActaPdf_Filename));
         GxWebStd.gx_hidden_field( context, "ORDENPDF_Filetype", StringUtil.RTrim( edtOrdenPdf_Filetype));
         GxWebStd.gx_hidden_field( context, "ORDENACTAPDF_Filetype", StringUtil.RTrim( edtOrdenActaPdf_Filetype));
      }

      protected void RenderHtmlCloseForm0H16( )
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
         return "OrdenProduccion" ;
      }

      public override String GetPgmdesc( )
      {
         return "Orden Produccion" ;
      }

      protected void InitializeNonKey0H16( )
      {
         A6MarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A6MarcaID), 4, 0)));
         A8VehiculoID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8VehiculoID", StringUtil.LTrim( StringUtil.Str( (decimal)(A8VehiculoID), 4, 0)));
         A26OrdenMarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26OrdenMarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0)));
         A17tipOrdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17tipOrdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0)));
         A9vendedorID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9vendedorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0)));
         A10protID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10protID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10protID), 4, 0)));
         AV22MarcaID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22MarcaID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22MarcaID), 4, 0)));
         A116OrdenUser = "";
         n116OrdenUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116OrdenUser", A116OrdenUser);
         A115OrdenEst = "";
         n115OrdenEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
         n115OrdenEst = (String.IsNullOrEmpty(StringUtil.RTrim( A115OrdenEst)) ? true : false);
         A169OrdenValManObr = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A169OrdenValManObr", StringUtil.LTrim( StringUtil.Str( A169OrdenValManObr, 10, 3)));
         A170OrdenTotGast = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A170OrdenTotGast", StringUtil.LTrim( StringUtil.Str( A170OrdenTotGast, 10, 3)));
         A164OrdenValMatPri = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A164OrdenValMatPri", StringUtil.LTrim( StringUtil.Str( A164OrdenValMatPri, 10, 3)));
         A171OrdenValRenta = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171OrdenValRenta", StringUtil.LTrim( StringUtil.Str( A171OrdenValRenta, 10, 3)));
         A44empdsc = "";
         n44empdsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44empdsc", A44empdsc);
         A57ClienteDsc = "";
         n57ClienteDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57ClienteDsc", A57ClienteDsc);
         A68VehiculoPlaca = "";
         n68VehiculoPlaca = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68VehiculoPlaca", A68VehiculoPlaca);
         A69VehiculoChasis = "";
         n69VehiculoChasis = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69VehiculoChasis", A69VehiculoChasis);
         A117OrdenModeloID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117OrdenModeloID", StringUtil.LTrim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0)));
         A104tipOrdDsc = "";
         n104tipOrdDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104tipOrdDsc", A104tipOrdDsc);
         A72vendedorDsc = "";
         n72vendedorDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A72vendedorDsc", A72vendedorDsc);
         A106facturaNro = 0;
         n106facturaNro = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106facturaNro", StringUtil.LTrim( StringUtil.Str( (decimal)(A106facturaNro), 8, 0)));
         n106facturaNro = ((0==A106facturaNro) ? true : false);
         A107representane = "";
         n107representane = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A107representane", A107representane);
         n107representane = (String.IsNullOrEmpty(StringUtil.RTrim( A107representane)) ? true : false);
         A203ordenNroPed = 0;
         n203ordenNroPed = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203ordenNroPed", StringUtil.LTrim( StringUtil.Str( (decimal)(A203ordenNroPed), 8, 0)));
         A74protDsc = "";
         n74protDsc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A74protDsc", A74protDsc);
         A108urlPdf = "";
         n108urlPdf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A108urlPdf", A108urlPdf);
         A109fchVenta = DateTime.MinValue;
         n109fchVenta = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109fchVenta", context.localUtil.Format(A109fchVenta, "99/99/9999"));
         n109fchVenta = ((DateTime.MinValue==A109fchVenta) ? true : false);
         A110cantDias = 0;
         n110cantDias = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110cantDias", StringUtil.LTrim( StringUtil.Str( (decimal)(A110cantDias), 4, 0)));
         n110cantDias = ((0==A110cantDias) ? true : false);
         A112documento = "";
         n112documento = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112documento", A112documento);
         A152OrdenPdf = "";
         n152OrdenPdf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152OrdenPdf", A152OrdenPdf);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenPdf_Internalname, "URL", context.PathToRelativeUrl( A152OrdenPdf), true);
         n152OrdenPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A152OrdenPdf)) ? true : false);
         A153OrdenActaPdf = "";
         n153OrdenActaPdf = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153OrdenActaPdf", A153OrdenActaPdf);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenActaPdf_Internalname, "URL", context.PathToRelativeUrl( A153OrdenActaPdf), true);
         n153OrdenActaPdf = (String.IsNullOrEmpty(StringUtil.RTrim( A153OrdenActaPdf)) ? true : false);
         A161OrdenSubtotal = 0;
         n161OrdenSubtotal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A161OrdenSubtotal", StringUtil.LTrim( StringUtil.Str( A161OrdenSubtotal, 10, 3)));
         n161OrdenSubtotal = ((Convert.ToDecimal(0)==A161OrdenSubtotal) ? true : false);
         A162OrdenValInds = 0;
         n162OrdenValInds = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A162OrdenValInds", StringUtil.LTrim( StringUtil.Str( A162OrdenValInds, 10, 3)));
         n162OrdenValInds = ((Convert.ToDecimal(0)==A162OrdenValInds) ? true : false);
         A163OrdenValEnrq = 0;
         n163OrdenValEnrq = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A163OrdenValEnrq", StringUtil.LTrim( StringUtil.Str( A163OrdenValEnrq, 10, 3)));
         n163OrdenValEnrq = ((Convert.ToDecimal(0)==A163OrdenValEnrq) ? true : false);
         A165OrdenValCal = 0;
         n165OrdenValCal = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165OrdenValCal", StringUtil.LTrim( StringUtil.Str( A165OrdenValCal, 10, 3)));
         n165OrdenValCal = ((Convert.ToDecimal(0)==A165OrdenValCal) ? true : false);
         A166OrdenValPint = 0;
         n166OrdenValPint = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166OrdenValPint", StringUtil.LTrim( StringUtil.Str( A166OrdenValPint, 10, 3)));
         A167OrdenValEstr = 0;
         n167OrdenValEstr = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167OrdenValEstr", StringUtil.LTrim( StringUtil.Str( A167OrdenValEstr, 10, 3)));
         A168OrdenValOtrs = 0;
         n168OrdenValOtrs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168OrdenValOtrs", StringUtil.LTrim( StringUtil.Str( A168OrdenValOtrs, 10, 3)));
         A172OrdenfchEnt = DateTime.MinValue;
         n172OrdenfchEnt = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172OrdenfchEnt", context.localUtil.Format(A172OrdenfchEnt, "99/99/9999"));
         n172OrdenfchEnt = ((DateTime.MinValue==A172OrdenfchEnt) ? true : false);
         A192OrdenPed = 0;
         n192OrdenPed = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192OrdenPed", StringUtil.LTrim( StringUtil.Str( (decimal)(A192OrdenPed), 8, 0)));
         A195OrdenFacNomb = "";
         n195OrdenFacNomb = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195OrdenFacNomb", A195OrdenFacNomb);
         n195OrdenFacNomb = (String.IsNullOrEmpty(StringUtil.RTrim( A195OrdenFacNomb)) ? true : false);
         A210OrdenUltSec = 0;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         A401OrdenNroDesp = 0;
         n401OrdenNroDesp = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401OrdenNroDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(A401OrdenNroDesp), 6, 0)));
         n401OrdenNroDesp = ((0==A401OrdenNroDesp) ? true : false);
         A255OrdenObreSuma = 0;
         n255OrdenObreSuma = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A255OrdenObreSuma", StringUtil.LTrim( StringUtil.Str( A255OrdenObreSuma, 10, 2)));
         A119OrdenFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n119OrdenFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
         A132OrdenEmpFac = 1;
         n132OrdenEmpFac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
         A133OrdenProceso = "PEND";
         n133OrdenProceso = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
         AV11facEmp = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
         AV43ordenDesp = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ordenDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43ordenDesp), 2, 0)));
         O210OrdenUltSec = A210OrdenUltSec;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
         Z116OrdenUser = "";
         Z115OrdenEst = "";
         Z117OrdenModeloID = 0;
         Z119OrdenFch = DateTime.MinValue;
         Z106facturaNro = 0;
         Z107representane = "";
         Z203ordenNroPed = 0;
         Z109fchVenta = DateTime.MinValue;
         Z110cantDias = 0;
         Z132OrdenEmpFac = 0;
         Z133OrdenProceso = "";
         Z161OrdenSubtotal = 0;
         Z162OrdenValInds = 0;
         Z163OrdenValEnrq = 0;
         Z165OrdenValCal = 0;
         Z166OrdenValPint = 0;
         Z167OrdenValEstr = 0;
         Z168OrdenValOtrs = 0;
         Z172OrdenfchEnt = DateTime.MinValue;
         Z192OrdenPed = 0;
         Z195OrdenFacNomb = "";
         Z210OrdenUltSec = 0;
         Z401OrdenNroDesp = 0;
         Z26OrdenMarcaID = 0;
         Z8VehiculoID = 0;
         Z9vendedorID = 0;
         Z10protID = 0;
         Z17tipOrdID = 0;
      }

      protected void InitAll0H16( )
      {
         A1EmpID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1EmpID), 4, 0)));
         A5ClienteID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5ClienteID", StringUtil.LTrim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0)));
         A24OrdenPeriodo = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
         A25OrdenAnio = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(A25OrdenAnio), 4, 0)));
         A22OrdenID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         InitializeNonKey0H16( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A115OrdenEst = i115OrdenEst;
         n115OrdenEst = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
         A116OrdenUser = i116OrdenUser;
         n116OrdenUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116OrdenUser", A116OrdenUser);
         A119OrdenFch = i119OrdenFch;
         n119OrdenFch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119OrdenFch", context.localUtil.Format(A119OrdenFch, "99/99/9999"));
         A133OrdenProceso = i133OrdenProceso;
         n133OrdenProceso = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133OrdenProceso", A133OrdenProceso);
         AV11facEmp = iV11facEmp;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11facEmp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11facEmp), 4, 0)));
         A132OrdenEmpFac = i132OrdenEmpFac;
         n132OrdenEmpFac = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132OrdenEmpFac", StringUtil.LTrim( StringUtil.Str( (decimal)(A132OrdenEmpFac), 4, 0)));
         AV43ordenDesp = iV43ordenDesp;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ordenDesp", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43ordenDesp), 2, 0)));
      }

      protected void InitializeNonKey0H52( )
      {
         A244ObreNombre = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A244ObreNombre", A244ObreNombre);
         A253OrdenObreManObra = "";
         n253OrdenObreManObra = false;
         A254OrdenObreValor = 0;
         n254OrdenObreValor = false;
         Z253OrdenObreManObra = "";
         Z254OrdenObreValor = 0;
      }

      protected void InitAll0H52( )
      {
         A252OrdenObrID = 0;
         A238ObreID = 0;
         InitializeNonKey0H52( ) ;
      }

      protected void StandaloneModalInsert0H52( )
      {
      }

      protected void InitializeNonKey0H17( )
      {
         A31tipoProdID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31tipoProdID", StringUtil.LTrim( StringUtil.Str( (decimal)(A31tipoProdID), 4, 0)));
         A209OrdenDetVal = 0;
         A36detTipoProdID = 0;
         A32categID = 0;
         A146categDsc = "";
         n146categDsc = false;
         A33subCatID = 0;
         A148subCatDsc = "";
         n148subCatDsc = false;
         A150subCatPrec = 0;
         n150subCatPrec = false;
         A208OrdenDetCant = 0;
         n208OrdenDetCant = false;
         A251OrdenDetDetalle = "";
         n251OrdenDetDetalle = false;
         A396OrdenDetDesp = 0;
         n396OrdenDetDesp = false;
         A397OrdenDesp = 0;
         n397OrdenDesp = false;
         Z208OrdenDetCant = 0;
         Z251OrdenDetDetalle = "";
         Z396OrdenDetDesp = 0;
         Z397OrdenDesp = 0;
         Z36detTipoProdID = 0;
         Z32categID = 0;
         Z33subCatID = 0;
      }

      protected void InitAll0H17( )
      {
         A41OrdenSecId = 0;
         InitializeNonKey0H17( ) ;
      }

      protected void StandaloneModalInsert0H17( )
      {
         A210OrdenUltSec = i210OrdenUltSec;
         n210OrdenUltSec = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210OrdenUltSec", StringUtil.LTrim( StringUtil.Str( (decimal)(A210OrdenUltSec), 4, 0)));
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20231170133093", true);
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
         context.AddJavascriptSource("ordenproduccion.js", "?20231170133094", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_level_properties52( )
      {
         dynObreID.Enabled = defdynObreID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynObreID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynObreID.Enabled), 5, 0)), !bGXsfl_261_Refreshing);
         edtOrdenObrID_Enabled = defedtOrdenObrID_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenObrID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenObrID_Enabled), 5, 0)), !bGXsfl_261_Refreshing);
      }

      protected void init_level_properties17( )
      {
         edtOrdenDesp_Enabled = defedtOrdenDesp_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenDesp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenDesp_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtcategDsc_Enabled = defedtcategDsc_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtcategDsc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtcategDsc_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
         edtOrdenSecId_Enabled = defedtOrdenSecId_Enabled;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrdenSecId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrdenSecId_Enabled), 5, 0)), !bGXsfl_216_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtOrdenFch_Internalname = "ORDENFCH";
         dynavUsucod_Internalname = "vUSUCOD";
         edtOrdenfchEnt_Internalname = "ORDENFCHENT";
         edtOrdenAnio_Internalname = "ORDENANIO";
         divSection3_Internalname = "SECTION3";
         cmbOrdenPeriodo_Internalname = "ORDENPERIODO";
         divSection2_Internalname = "SECTION2";
         dynOrdenProceso_Internalname = "ORDENPROCESO";
         divSection1_Internalname = "SECTION1";
         divTable1_Internalname = "TABLE1";
         edtEmpID_Internalname = "EMPID";
         edtempdsc_Internalname = "EMPDSC";
         chkavFacemp_Internalname = "vFACEMP";
         dynOrdenEmpFac_Internalname = "ORDENEMPFAC";
         divTbempfac_Internalname = "TBEMPFAC";
         dynOrdenMarcaID_Internalname = "ORDENMARCAID";
         dynOrdenModeloID_Internalname = "ORDENMODELOID";
         dynClienteID_Internalname = "CLIENTEID";
         edtOrdenFacNomb_Internalname = "ORDENFACNOMB";
         divTbnomfac_Internalname = "TBNOMFAC";
         dynvendedorID_Internalname = "VENDEDORID";
         edtOrdenID_Internalname = "ORDENID";
         dyntipOrdID_Internalname = "TIPORDID";
         dynprotID_Internalname = "PROTID";
         edtfacturaNro_Internalname = "FACTURANRO";
         edtrepresentane_Internalname = "REPRESENTANE";
         edtVehiculoID_Internalname = "VEHICULOID";
         edtVehiculoPlaca_Internalname = "VEHICULOPLACA";
         edtVehiculoChasis_Internalname = "VEHICULOCHASIS";
         edtOrdenPdf_Internalname = "ORDENPDF";
         edtfchVenta_Internalname = "FCHVENTA";
         edtcantDias_Internalname = "CANTDIAS";
         edtOrdenActaPdf_Internalname = "ORDENACTAPDF";
         edtOrdenSubtotal_Internalname = "ORDENSUBTOTAL";
         cmbOrdenEst_Internalname = "ORDENEST";
         edtOrdenNroDesp_Internalname = "ORDENNRODESP";
         lblItems_title_Internalname = "ITEMS_TITLE";
         edtavErrormesjtool_Internalname = "vERRORMESJTOOL";
         bttButton3_Internalname = "BUTTON3";
         bttButton1_Internalname = "BUTTON1";
         edtOrdenSecId_Internalname = "ORDENSECID";
         dyndetTipoProdID_Internalname = "DETTIPOPRODID";
         dyncategID_Internalname = "CATEGID";
         edtcategDsc_Internalname = "CATEGDSC";
         edtsubCatID_Internalname = "SUBCATID";
         edtsubCatDsc_Internalname = "SUBCATDSC";
         chkOrdenDetDesp_Internalname = "ORDENDETDESP";
         edtsubCatPrec_Internalname = "SUBCATPREC";
         edtOrdenDetCant_Internalname = "ORDENDETCANT";
         edtOrdenDetVal_Internalname = "ORDENDETVAL";
         edtOrdenDetDetalle_Internalname = "ORDENDETDETALLE";
         edtOrdenDesp_Internalname = "ORDENDESP";
         divTabpage1table3_Internalname = "TABPAGE1TABLE3";
         lblCosteomatprim_title_Internalname = "COSTEOMATPRIM_TITLE";
         edtOrdenValInds_Internalname = "ORDENVALINDS";
         edtOrdenValEnrq_Internalname = "ORDENVALENRQ";
         edtOrdenValCal_Internalname = "ORDENVALCAL";
         edtOrdenValMatPri_Internalname = "ORDENVALMATPRI";
         divTabpage1table_Internalname = "TABPAGE1TABLE";
         lblManoobra_title_Internalname = "MANOOBRA_TITLE";
         edtOrdenObrID_Internalname = "ORDENOBRID";
         dynObreID_Internalname = "OBREID";
         edtOrdenObreManObra_Internalname = "ORDENOBREMANOBRA";
         edtOrdenObreValor_Internalname = "ORDENOBREVALOR";
         edtOrdenObreSuma_Internalname = "ORDENOBRESUMA";
         divTabpage1table1_Internalname = "TABPAGE1TABLE1";
         lblTotalrenta_title_Internalname = "TOTALRENTA_TITLE";
         edtOrdenTotGast_Internalname = "ORDENTOTGAST";
         edtOrdenValRenta_Internalname = "ORDENVALRENTA";
         divTabpage1table2_Internalname = "TABPAGE1TABLE2";
         Tabcosteo_Internalname = "TABCOSTEO";
         divFormcontainer_Internalname = "FORMCONTAINER";
         edtavMarcaid_Internalname = "vMARCAID";
         edtavEmpid_Internalname = "vEMPID";
         edtavValuenro_Internalname = "vVALUENRO";
         bttBtnenter2_Internalname = "BTNENTER2";
         bttButton2_Internalname = "BUTTON2";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_1_Internalname = "PROMPT_1";
         imgprompt_26_Internalname = "PROMPT_26";
         imgprompt_5_Internalname = "PROMPT_5";
         imgprompt_9_Internalname = "PROMPT_9";
         imgprompt_17_Internalname = "PROMPT_17";
         imgprompt_10_Internalname = "PROMPT_10";
         imgprompt_8_Internalname = "PROMPT_8";
         imgprompt_36_Internalname = "PROMPT_36";
         imgprompt_32_Internalname = "PROMPT_32";
         imgprompt_33_Internalname = "PROMPT_33";
         subGriditemsop_Internalname = "GRIDITEMSOP";
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
         edtOrdenActaPdf_Filename = "";
         edtOrdenPdf_Filename = "";
         Tabcosteo_Historymanagement = Convert.ToBoolean( -1);
         Tabcosteo_Pagecount = 4;
         Tabcosteo_Class = "WWTab";
         edtOrdenDesp_Jsonclick = "";
         edtOrdenDetDetalle_Jsonclick = "";
         edtOrdenDetVal_Jsonclick = "";
         edtOrdenDetCant_Jsonclick = "";
         edtsubCatPrec_Jsonclick = "";
         edtsubCatDsc_Jsonclick = "";
         imgprompt_33_Visible = 1;
         imgprompt_33_Link = "";
         edtsubCatID_Jsonclick = "";
         edtcategDsc_Jsonclick = "";
         imgprompt_32_Visible = 1;
         imgprompt_32_Link = "";
         dyncategID_Jsonclick = "";
         imgprompt_36_Visible = 1;
         imgprompt_36_Link = "";
         imgprompt_1_Visible = 1;
         dyndetTipoProdID_Jsonclick = "";
         edtOrdenSecId_Jsonclick = "";
         subGriditemsop_Class = "Grid";
         subGriditemsop_Backcolorstyle = 0;
         edtOrdenObreValor_Jsonclick = "";
         edtOrdenObreManObra_Jsonclick = "";
         dynObreID_Jsonclick = "";
         edtOrdenObrID_Jsonclick = "";
         subGrid1_Class = "GridManoObra";
         subGrid1_Backcolorstyle = 0;
         Tabcosteo_Visible = Convert.ToBoolean( -1);
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtOrdenObreValor_Enabled = 1;
         edtOrdenObreManObra_Enabled = 1;
         dynObreID.Enabled = 1;
         edtOrdenObrID_Enabled = 1;
         subGrid1_Header = "";
         subGriditemsop_Allowcollapsing = 0;
         subGriditemsop_Allowselection = 0;
         edtOrdenDesp_Enabled = 0;
         edtOrdenDetDetalle_Enabled = 1;
         edtOrdenDetVal_Enabled = 0;
         edtOrdenDetCant_Enabled = 1;
         edtsubCatPrec_Enabled = 0;
         edtsubCatDsc_Enabled = 0;
         edtsubCatID_Enabled = 1;
         edtcategDsc_Enabled = 0;
         dyncategID.Enabled = 1;
         dyndetTipoProdID.Enabled = 1;
         edtOrdenSecId_Enabled = 0;
         subGriditemsop_Sortable = 0;
         subGriditemsop_Header = "";
         bttButton2_Visible = 1;
         bttBtnenter2_Visible = 1;
         edtavValuenro_Jsonclick = "";
         edtavValuenro_Enabled = 0;
         edtavValuenro_Visible = 1;
         edtavEmpid_Jsonclick = "";
         edtavEmpid_Enabled = 0;
         edtavEmpid_Visible = 1;
         edtavMarcaid_Jsonclick = "";
         edtavMarcaid_Enabled = 0;
         edtavMarcaid_Visible = 1;
         edtOrdenValRenta_Jsonclick = "";
         edtOrdenValRenta_Enabled = 0;
         edtOrdenTotGast_Jsonclick = "";
         edtOrdenTotGast_Enabled = 0;
         edtOrdenObreSuma_Jsonclick = "";
         edtOrdenObreSuma_Enabled = 0;
         edtOrdenValMatPri_Jsonclick = "";
         edtOrdenValMatPri_Enabled = 0;
         edtOrdenValCal_Jsonclick = "";
         edtOrdenValCal_Enabled = 1;
         edtOrdenValEnrq_Jsonclick = "";
         edtOrdenValEnrq_Enabled = 1;
         edtOrdenValInds_Jsonclick = "";
         edtOrdenValInds_Enabled = 1;
         bttButton1_Visible = 1;
         bttButton3_Visible = 1;
         edtavErrormesjtool_Jsonclick = "";
         edtavErrormesjtool_Enabled = 0;
         edtOrdenNroDesp_Jsonclick = "";
         edtOrdenNroDesp_Enabled = 1;
         cmbOrdenEst_Jsonclick = "";
         cmbOrdenEst.Enabled = 1;
         edtOrdenSubtotal_Jsonclick = "";
         edtOrdenSubtotal_Enabled = 1;
         edtOrdenActaPdf_Jsonclick = "";
         edtOrdenActaPdf_Parameters = "";
         edtOrdenActaPdf_Contenttype = "";
         edtOrdenActaPdf_Filetype = "";
         edtOrdenActaPdf_Enabled = 1;
         edtcantDias_Jsonclick = "";
         edtcantDias_Enabled = 1;
         edtfchVenta_Jsonclick = "";
         edtfchVenta_Enabled = 1;
         edtOrdenPdf_Jsonclick = "";
         edtOrdenPdf_Parameters = "";
         edtOrdenPdf_Contenttype = "";
         edtOrdenPdf_Filetype = "";
         edtOrdenPdf_Enabled = 1;
         edtVehiculoChasis_Jsonclick = "";
         edtVehiculoChasis_Enabled = 0;
         edtVehiculoPlaca_Jsonclick = "";
         edtVehiculoPlaca_Enabled = 0;
         imgprompt_8_Visible = 1;
         imgprompt_8_Link = "";
         edtVehiculoID_Jsonclick = "";
         edtVehiculoID_Enabled = 1;
         edtrepresentane_Jsonclick = "";
         edtrepresentane_Enabled = 1;
         edtfacturaNro_Jsonclick = "";
         edtfacturaNro_Enabled = 1;
         imgprompt_10_Visible = 1;
         imgprompt_10_Link = "";
         dynprotID_Jsonclick = "";
         dynprotID.Enabled = 1;
         imgprompt_17_Visible = 1;
         imgprompt_17_Link = "";
         dyntipOrdID_Jsonclick = "";
         dyntipOrdID.Enabled = 1;
         edtOrdenID_Jsonclick = "";
         edtOrdenID_Enabled = 1;
         imgprompt_9_Visible = 1;
         imgprompt_9_Link = "";
         dynvendedorID_Jsonclick = "";
         dynvendedorID.Enabled = 1;
         edtOrdenFacNomb_Jsonclick = "";
         edtOrdenFacNomb_Enabled = 1;
         edtOrdenFacNomb_Visible = 1;
         imgprompt_5_Visible = 1;
         imgprompt_5_Link = "";
         dynClienteID_Jsonclick = "";
         dynClienteID.Enabled = 1;
         dynOrdenModeloID_Jsonclick = "";
         dynOrdenModeloID.Enabled = 1;
         imgprompt_26_Visible = 1;
         imgprompt_26_Link = "";
         dynOrdenMarcaID_Jsonclick = "";
         dynOrdenMarcaID.Enabled = 1;
         dynOrdenEmpFac_Jsonclick = "";
         dynOrdenEmpFac.Enabled = 1;
         divTbempfac_Visible = 1;
         chkavFacemp.Enabled = 0;
         edtempdsc_Jsonclick = "";
         edtempdsc_Enabled = 0;
         imgprompt_1_Visible = 1;
         imgprompt_1_Link = "";
         edtEmpID_Jsonclick = "";
         edtEmpID_Enabled = 1;
         dynOrdenProceso_Jsonclick = "";
         dynOrdenProceso.Enabled = 1;
         cmbOrdenPeriodo_Jsonclick = "";
         cmbOrdenPeriodo.Enabled = 1;
         edtOrdenAnio_Jsonclick = "";
         edtOrdenAnio_Enabled = 1;
         edtOrdenfchEnt_Jsonclick = "";
         edtOrdenfchEnt_Enabled = 1;
         edtOrdenfchEnt_Visible = 1;
         dynavUsucod_Jsonclick = "";
         dynavUsucod.Enabled = 0;
         edtOrdenFch_Jsonclick = "";
         edtOrdenFch_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         chkOrdenDetDesp.Enabled = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
         GXACATEGID_html0H17( A1EmpID, A36detTipoProdID) ;
         /* End function dynload_actions */
      }

      protected void GXDLVvUSUCOD0H16( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvUSUCOD_data0H16( ) ;
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

      protected void GXVvUSUCOD_html0H16( )
      {
         String gxdynajaxvalue ;
         GXDLVvUSUCOD_data0H16( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavUsucod.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavUsucod.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvUSUCOD_data0H16( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H68 */
         pr_default.execute(62);
         while ( (pr_default.getStatus(62) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( T000H68_A3UsuCod[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H68_A398UsuAlias[0]));
            pr_default.readNext(62);
         }
         pr_default.close(62);
      }

      protected void GXDLAORDENPROCESO0H16( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAORDENPROCESO_data0H16( ) ;
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

      protected void GXAORDENPROCESO_html0H16( )
      {
         String gxdynajaxvalue ;
         GXDLAORDENPROCESO_data0H16( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynOrdenProceso.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynOrdenProceso.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAORDENPROCESO_data0H16( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H69 */
         pr_default.execute(63);
         while ( (pr_default.getStatus(63) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000H69_A129ProcAbre[0]);
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H69_A128ProcDsc[0]));
            pr_default.readNext(63);
         }
         pr_default.close(63);
      }

      protected void GXDLAORDENEMPFAC0H16( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAORDENEMPFAC_data0H16( ) ;
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

      protected void GXAORDENEMPFAC_html0H16( )
      {
         short gxdynajaxvalue ;
         GXDLAORDENEMPFAC_data0H16( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynOrdenEmpFac.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynOrdenEmpFac.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAORDENEMPFAC_data0H16( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H70 */
         pr_default.execute(64);
         while ( (pr_default.getStatus(64) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H70_A1EmpID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T000H70_A44empdsc[0]);
            pr_default.readNext(64);
         }
         pr_default.close(64);
      }

      protected void GXDLAORDENMARCAID0H16( short AV10EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAORDENMARCAID_data0H16( AV10EmpID) ;
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

      protected void GXAORDENMARCAID_html0H16( short AV10EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAORDENMARCAID_data0H16( AV10EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynOrdenMarcaID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynOrdenMarcaID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAORDENMARCAID_data0H16( short AV10EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H71 */
         pr_default.execute(65, new Object[] {AV10EmpID});
         while ( (pr_default.getStatus(65) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H71_A6MarcaID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H71_A62MarcaDsc[0]));
            pr_default.readNext(65);
         }
         pr_default.close(65);
      }

      protected void GXDLAORDENMODELOID0H16( short AV10EmpID ,
                                             short AV22MarcaID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAORDENMODELOID_data0H16( AV10EmpID, AV22MarcaID) ;
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

      protected void GXAORDENMODELOID_html0H16( short AV10EmpID ,
                                                short AV22MarcaID )
      {
         short gxdynajaxvalue ;
         GXDLAORDENMODELOID_data0H16( AV10EmpID, AV22MarcaID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynOrdenModeloID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynOrdenModeloID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAORDENMODELOID_data0H16( short AV10EmpID ,
                                                  short AV22MarcaID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H72 */
         pr_default.execute(66, new Object[] {AV10EmpID, AV22MarcaID});
         while ( (pr_default.getStatus(66) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H72_A7ModeloID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H72_A64ModeloDsc[0]));
            pr_default.readNext(66);
         }
         pr_default.close(66);
      }

      protected void GXDLACLIENTEID0H16( short AV10EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLACLIENTEID_data0H16( AV10EmpID) ;
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

      protected void GXACLIENTEID_html0H16( short AV10EmpID )
      {
         short gxdynajaxvalue ;
         GXDLACLIENTEID_data0H16( AV10EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynClienteID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynClienteID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLACLIENTEID_data0H16( short AV10EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H73 */
         pr_default.execute(67, new Object[] {AV10EmpID});
         while ( (pr_default.getStatus(67) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H73_A5ClienteID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H73_A57ClienteDsc[0]));
            pr_default.readNext(67);
         }
         pr_default.close(67);
      }

      protected void GXDLAVENDEDORID0H16( short AV10EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAVENDEDORID_data0H16( AV10EmpID) ;
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

      protected void GXAVENDEDORID_html0H16( short AV10EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAVENDEDORID_data0H16( AV10EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynvendedorID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynvendedorID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAVENDEDORID_data0H16( short AV10EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H74 */
         pr_default.execute(68, new Object[] {AV10EmpID});
         while ( (pr_default.getStatus(68) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H74_A9vendedorID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H74_A72vendedorDsc[0]));
            pr_default.readNext(68);
         }
         pr_default.close(68);
      }

      protected void GXDLATIPORDID0H16( short AV10EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLATIPORDID_data0H16( AV10EmpID) ;
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

      protected void GXATIPORDID_html0H16( short AV10EmpID )
      {
         short gxdynajaxvalue ;
         GXDLATIPORDID_data0H16( AV10EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dyntipOrdID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dyntipOrdID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLATIPORDID_data0H16( short AV10EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H75 */
         pr_default.execute(69, new Object[] {AV10EmpID});
         while ( (pr_default.getStatus(69) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H75_A17tipOrdID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H75_A104tipOrdDsc[0]));
            pr_default.readNext(69);
         }
         pr_default.close(69);
      }

      protected void GXDLAPROTID0H16( short AV10EmpID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAPROTID_data0H16( AV10EmpID) ;
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

      protected void GXAPROTID_html0H16( short AV10EmpID )
      {
         short gxdynajaxvalue ;
         GXDLAPROTID_data0H16( AV10EmpID) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynprotID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynprotID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAPROTID_data0H16( short AV10EmpID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H76 */
         pr_default.execute(70, new Object[] {AV10EmpID});
         while ( (pr_default.getStatus(70) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H76_A10protID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H76_A74protDsc[0]));
            pr_default.readNext(70);
         }
         pr_default.close(70);
      }

      protected void GXDLAOBREID0H52( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLAOBREID_data0H52( ) ;
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

      protected void GXAOBREID_html0H52( )
      {
         short gxdynajaxvalue ;
         GXDLAOBREID_data0H52( ) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynObreID.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (short)(NumberUtil.Val( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)), "."));
            dynObreID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(gxdynajaxvalue), 4, 0)), ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLAOBREID_data0H52( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar Obrero");
         /* Using cursor T000H77 */
         pr_default.execute(71);
         while ( (pr_default.getStatus(71) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H77_A238ObreID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(T000H77_A244ObreNombre[0]);
            pr_default.readNext(71);
         }
         pr_default.close(71);
      }

      protected void GXDLADETTIPOPRODID0H17( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLADETTIPOPRODID_data0H17( ) ;
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

      protected void GXADETTIPOPRODID_html0H17( )
      {
         short gxdynajaxvalue ;
         GXDLADETTIPOPRODID_data0H17( ) ;
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

      protected void GXDLADETTIPOPRODID_data0H17( )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("--Seleccionar--");
         /* Using cursor T000H78 */
         pr_default.execute(72);
         while ( (pr_default.getStatus(72) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H78_A31tipoProdID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H78_A144tipoProdDsc[0]));
            pr_default.readNext(72);
         }
         pr_default.close(72);
      }

      protected void GXDLACATEGID0H17( short A1EmpID ,
                                       short A36detTipoProdID )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLACATEGID_data0H17( A1EmpID, A36detTipoProdID) ;
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

      protected void GXACATEGID_html0H17( short A1EmpID ,
                                          short A36detTipoProdID )
      {
         short gxdynajaxvalue ;
         GXDLACATEGID_data0H17( A1EmpID, A36detTipoProdID) ;
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

      protected void GXDLACATEGID_data0H17( short A1EmpID ,
                                            short A36detTipoProdID )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("Seleccionar");
         /* Using cursor T000H79 */
         pr_default.execute(73, new Object[] {A1EmpID, A36detTipoProdID});
         while ( (pr_default.getStatus(73) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(T000H79_A32categID[0]), 4, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( T000H79_A146categDsc[0]));
            pr_default.readNext(73);
         }
         pr_default.close(73);
      }

      protected void GX18ASAORDENID0H16( short AV26OrdenID ,
                                         short AV10EmpID ,
                                         short AV25OrdenAnio )
      {
         if ( ! (0==AV26OrdenID) )
         {
            A22OrdenID = AV26OrdenID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               GXt_int1 = A22OrdenID;
               new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
               A22OrdenID = GXt_int1;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22OrdenID", StringUtil.LTrim( StringUtil.Str( (decimal)(A22OrdenID), 4, 0)));
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22OrdenID), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX32ASAVALUENRO0H16( short AV10EmpID ,
                                          short AV25OrdenAnio )
      {
         GXt_int1 = AV34valueNro;
         new obtultcodop(context ).execute(  AV10EmpID,  AV25OrdenAnio, out  GXt_int1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10EmpID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10EmpID), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vEMPID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10EmpID), "ZZZ9"), context));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25OrdenAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25OrdenAnio), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vORDENANIO", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV25OrdenAnio), "ZZZ9"), context));
         AV34valueNro = GXt_int1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34valueNro", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34valueNro), 4, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34valueNro), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_26152( ) ;
         while ( nGXsfl_261_idx <= nRC_GXsfl_261 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0H52( ) ;
            standaloneModal0H52( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0H52( ) ;
            nGXsfl_261_idx = (short)(nGXsfl_261_idx+1);
            sGXsfl_261_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_261_idx), 4, 0)), 4, "0");
            SubsflControlProps_26152( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( Grid1Container));
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGriditemsop_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_21617( ) ;
         while ( nGXsfl_216_idx <= nRC_GXsfl_216 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0H17( ) ;
            standaloneModal0H17( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0H17( ) ;
            nGXsfl_216_idx = (short)(nGXsfl_216_idx+1);
            sGXsfl_216_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_216_idx), 4, 0)), 4, "0");
            SubsflControlProps_21617( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GriditemsopContainer));
         /* End function gxnrGriditemsop_newrow */
      }

      protected void init_web_controls( )
      {
         dynavUsucod.Name = "vUSUCOD";
         dynavUsucod.WebTags = "";
         cmbOrdenPeriodo.Name = "ORDENPERIODO";
         cmbOrdenPeriodo.WebTags = "";
         cmbOrdenPeriodo.addItem("0", "Seleccionar", 0);
         cmbOrdenPeriodo.addItem("1", "Enero", 0);
         cmbOrdenPeriodo.addItem("2", "Febrero", 0);
         cmbOrdenPeriodo.addItem("3", "Marzo", 0);
         cmbOrdenPeriodo.addItem("4", "Abril", 0);
         cmbOrdenPeriodo.addItem("5", "Mayo", 0);
         cmbOrdenPeriodo.addItem("6", "Junio", 0);
         cmbOrdenPeriodo.addItem("7", "Julio", 0);
         cmbOrdenPeriodo.addItem("8", "Agosto", 0);
         cmbOrdenPeriodo.addItem("9", "Septiembre", 0);
         cmbOrdenPeriodo.addItem("10", "Octubre", 0);
         cmbOrdenPeriodo.addItem("11", "Noviembre", 0);
         cmbOrdenPeriodo.addItem("12", "Diciembre", 0);
         if ( cmbOrdenPeriodo.ItemCount > 0 )
         {
            A24OrdenPeriodo = (short)(NumberUtil.Val( cmbOrdenPeriodo.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24OrdenPeriodo", StringUtil.LTrim( StringUtil.Str( (decimal)(A24OrdenPeriodo), 2, 0)));
         }
         dynOrdenProceso.Name = "ORDENPROCESO";
         dynOrdenProceso.WebTags = "";
         chkavFacemp.Name = "vFACEMP";
         chkavFacemp.WebTags = "";
         chkavFacemp.Caption = "Misma empresa";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavFacemp_Internalname, "TitleCaption", chkavFacemp.Caption, true);
         chkavFacemp.CheckedValue = "0";
         dynOrdenEmpFac.Name = "ORDENEMPFAC";
         dynOrdenEmpFac.WebTags = "";
         dynOrdenMarcaID.Name = "ORDENMARCAID";
         dynOrdenMarcaID.WebTags = "";
         dynOrdenModeloID.Name = "ORDENMODELOID";
         dynOrdenModeloID.WebTags = "";
         dynClienteID.Name = "CLIENTEID";
         dynClienteID.WebTags = "";
         dynvendedorID.Name = "VENDEDORID";
         dynvendedorID.WebTags = "";
         dyntipOrdID.Name = "TIPORDID";
         dyntipOrdID.WebTags = "";
         dynprotID.Name = "PROTID";
         dynprotID.WebTags = "";
         cmbOrdenEst.Name = "ORDENEST";
         cmbOrdenEst.WebTags = "";
         cmbOrdenEst.addItem("", "Seleccionar", 0);
         cmbOrdenEst.addItem("A", "Activo", 0);
         cmbOrdenEst.addItem("I", "Inactivo", 0);
         if ( cmbOrdenEst.ItemCount > 0 )
         {
            A115OrdenEst = cmbOrdenEst.getValidValue(A115OrdenEst);
            n115OrdenEst = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115OrdenEst", A115OrdenEst);
         }
         GXCCtl = "DETTIPOPRODID_" + sGXsfl_216_idx;
         dyndetTipoProdID.Name = GXCCtl;
         dyndetTipoProdID.WebTags = "";
         GXCCtl = "CATEGID_" + sGXsfl_216_idx;
         dyncategID.Name = GXCCtl;
         dyncategID.WebTags = "";
         GXCCtl = "ORDENDETDESP_" + sGXsfl_216_idx;
         chkOrdenDetDesp.Name = GXCCtl;
         chkOrdenDetDesp.WebTags = "";
         chkOrdenDetDesp.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkOrdenDetDesp_Internalname, "TitleCaption", chkOrdenDetDesp.Caption, !bGXsfl_216_Refreshing);
         chkOrdenDetDesp.CheckedValue = "0";
         GXCCtl = "OBREID_" + sGXsfl_261_idx;
         dynObreID.Name = GXCCtl;
         dynObreID.WebTags = "";
         /* End function init_web_controls */
      }

      public void Valid_Empid( short GX_Parm1 ,
                               short GX_Parm2 ,
                               GXCombobox dynGX_Parm3 ,
                               String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A6MarcaID = GX_Parm2;
         dyndetTipoProdID = dynGX_Parm3;
         A36detTipoProdID = (short)(NumberUtil.Val( dyndetTipoProdID.CurrentValue, "."));
         A44empdsc = GX_Parm4;
         n44empdsc = false;
         /* Using cursor T000H42 */
         pr_default.execute(37, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(37) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A44empdsc = T000H42_A44empdsc[0];
         n44empdsc = T000H42_n44empdsc[0];
         pr_default.close(37);
         /* Using cursor T000H80 */
         pr_default.execute(74, new Object[] {A1EmpID, A6MarcaID});
         if ( (pr_default.getStatus(74) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         pr_default.close(74);
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

      public void Valid_Clienteid( short GX_Parm1 ,
                                   GXCombobox dynGX_Parm2 ,
                                   String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dynClienteID = dynGX_Parm2;
         A5ClienteID = (short)(NumberUtil.Val( dynClienteID.CurrentValue, "."));
         A57ClienteDsc = GX_Parm3;
         n57ClienteDsc = false;
         /* Using cursor T000H43 */
         pr_default.execute(38, new Object[] {A1EmpID, A5ClienteID});
         if ( (pr_default.getStatus(38) == 101) )
         {
            GX_msglist.addItem("No existe 'Clientes'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A57ClienteDsc = T000H43_A57ClienteDsc[0];
         n57ClienteDsc = T000H43_n57ClienteDsc[0];
         pr_default.close(38);
         if ( A5ClienteID == 9999 )
         {
            edtOrdenFacNomb_Visible = 1;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A57ClienteDsc = "";
            n57ClienteDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A57ClienteDsc));
         isValidOutput.Add(edtOrdenFacNomb_Visible);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Ordenid( short GX_Parm1 ,
                                 GXCombobox dynGX_Parm2 ,
                                 GXCombobox cmbGX_Parm3 ,
                                 short GX_Parm4 ,
                                 short GX_Parm5 ,
                                 decimal GX_Parm6 )
      {
         A1EmpID = GX_Parm1;
         dynClienteID = dynGX_Parm2;
         A5ClienteID = (short)(NumberUtil.Val( dynClienteID.CurrentValue, "."));
         cmbOrdenPeriodo = cmbGX_Parm3;
         A24OrdenPeriodo = (short)(NumberUtil.Val( cmbOrdenPeriodo.CurrentValue, "."));
         A25OrdenAnio = GX_Parm4;
         A22OrdenID = GX_Parm5;
         A255OrdenObreSuma = GX_Parm6;
         n255OrdenObreSuma = false;
         /* Using cursor T000H45 */
         pr_default.execute(39, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         if ( (pr_default.getStatus(39) != 101) )
         {
            A255OrdenObreSuma = T000H45_A255OrdenObreSuma[0];
            n255OrdenObreSuma = T000H45_n255OrdenObreSuma[0];
         }
         else
         {
            A255OrdenObreSuma = 0;
            n255OrdenObreSuma = false;
         }
         pr_default.close(39);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A255OrdenObreSuma = 0;
            n255OrdenObreSuma = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A255OrdenObreSuma, 10, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Ordenmarcaid( short GX_Parm1 ,
                                      GXCombobox dynGX_Parm2 ,
                                      short GX_Parm3 ,
                                      short GX_Parm4 ,
                                      GXCombobox dynGX_Parm5 )
      {
         A1EmpID = GX_Parm1;
         dynOrdenMarcaID = dynGX_Parm2;
         A26OrdenMarcaID = (short)(NumberUtil.Val( dynOrdenMarcaID.CurrentValue, "."));
         AV10EmpID = GX_Parm3;
         AV22MarcaID = GX_Parm4;
         dynOrdenModeloID = dynGX_Parm5;
         A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.CurrentValue, "."));
         /* Using cursor T000H81 */
         pr_default.execute(75, new Object[] {A1EmpID, A26OrdenMarcaID});
         if ( (pr_default.getStatus(75) == 101) )
         {
            GX_msglist.addItem("No existe 'Marca'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         pr_default.close(75);
         AV22MarcaID = A26OrdenMarcaID;
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22MarcaID), 4, 0, ".", "")));
         if ( dynOrdenModeloID.ItemCount > 0 )
         {
            A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0))), "."));
         }
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         isValidOutput.Add(dynOrdenModeloID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Vendedorid( short GX_Parm1 ,
                                    GXCombobox dynGX_Parm2 ,
                                    String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dynvendedorID = dynGX_Parm2;
         A9vendedorID = (short)(NumberUtil.Val( dynvendedorID.CurrentValue, "."));
         A72vendedorDsc = GX_Parm3;
         n72vendedorDsc = false;
         /* Using cursor T000H48 */
         pr_default.execute(42, new Object[] {A1EmpID, A9vendedorID});
         if ( (pr_default.getStatus(42) == 101) )
         {
            GX_msglist.addItem("No existe 'Vendedor'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A72vendedorDsc = T000H48_A72vendedorDsc[0];
         n72vendedorDsc = T000H48_n72vendedorDsc[0];
         pr_default.close(42);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A72vendedorDsc = "";
            n72vendedorDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A72vendedorDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Tipordid( short GX_Parm1 ,
                                  GXCombobox dynGX_Parm2 ,
                                  String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dyntipOrdID = dynGX_Parm2;
         A17tipOrdID = (short)(NumberUtil.Val( dyntipOrdID.CurrentValue, "."));
         A104tipOrdDsc = GX_Parm3;
         n104tipOrdDsc = false;
         /* Using cursor T000H47 */
         pr_default.execute(41, new Object[] {A1EmpID, A17tipOrdID});
         if ( (pr_default.getStatus(41) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Orden'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A104tipOrdDsc = T000H47_A104tipOrdDsc[0];
         n104tipOrdDsc = T000H47_n104tipOrdDsc[0];
         pr_default.close(41);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A104tipOrdDsc = "";
            n104tipOrdDsc = false;
         }
         isValidOutput.Add(StringUtil.RTrim( A104tipOrdDsc));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Protid( short GX_Parm1 ,
                                GXCombobox dynGX_Parm2 ,
                                String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dynprotID = dynGX_Parm2;
         A10protID = (short)(NumberUtil.Val( dynprotID.CurrentValue, "."));
         A74protDsc = GX_Parm3;
         n74protDsc = false;
         /* Using cursor T000H49 */
         pr_default.execute(43, new Object[] {A1EmpID, A10protID});
         if ( (pr_default.getStatus(43) == 101) )
         {
            GX_msglist.addItem("No existe 'Prototipo'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A74protDsc = T000H49_A74protDsc[0];
         n74protDsc = T000H49_n74protDsc[0];
         pr_default.close(43);
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

      public void Valid_Vehiculoid( short GX_Parm1 ,
                                    short GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 )
      {
         A1EmpID = GX_Parm1;
         A8VehiculoID = GX_Parm2;
         A68VehiculoPlaca = GX_Parm3;
         n68VehiculoPlaca = false;
         A69VehiculoChasis = GX_Parm4;
         n69VehiculoChasis = false;
         /* Using cursor T000H46 */
         pr_default.execute(40, new Object[] {A1EmpID, A8VehiculoID});
         if ( (pr_default.getStatus(40) == 101) )
         {
            GX_msglist.addItem("No existe 'Vehiculos'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
            GX_FocusControl = edtEmpID_Internalname;
         }
         A68VehiculoPlaca = T000H46_A68VehiculoPlaca[0];
         n68VehiculoPlaca = T000H46_n68VehiculoPlaca[0];
         A69VehiculoChasis = T000H46_A69VehiculoChasis[0];
         n69VehiculoChasis = T000H46_n69VehiculoChasis[0];
         pr_default.close(40);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A68VehiculoPlaca = "";
            n68VehiculoPlaca = false;
            A69VehiculoChasis = "";
            n69VehiculoChasis = false;
         }
         isValidOutput.Add(A68VehiculoPlaca);
         isValidOutput.Add(A69VehiculoChasis);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Marcaid( short GX_Parm1 ,
                                  short GX_Parm2 ,
                                  GXCombobox dynGX_Parm3 )
      {
         AV10EmpID = GX_Parm1;
         AV22MarcaID = GX_Parm2;
         dynOrdenModeloID = dynGX_Parm3;
         A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.CurrentValue, "."));
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         if ( dynOrdenModeloID.ItemCount > 0 )
         {
            A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0))), "."));
         }
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         isValidOutput.Add(dynOrdenModeloID);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Empid( short GX_Parm1 ,
                                short GX_Parm2 ,
                                GXCombobox dynGX_Parm3 ,
                                GXCombobox dynGX_Parm4 ,
                                GXCombobox dynGX_Parm5 ,
                                GXCombobox dynGX_Parm6 ,
                                GXCombobox dynGX_Parm7 ,
                                GXCombobox dynGX_Parm8 )
      {
         AV10EmpID = GX_Parm1;
         AV22MarcaID = GX_Parm2;
         dynOrdenMarcaID = dynGX_Parm3;
         A26OrdenMarcaID = (short)(NumberUtil.Val( dynOrdenMarcaID.CurrentValue, "."));
         dynOrdenModeloID = dynGX_Parm4;
         A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.CurrentValue, "."));
         dynClienteID = dynGX_Parm5;
         A5ClienteID = (short)(NumberUtil.Val( dynClienteID.CurrentValue, "."));
         dynvendedorID = dynGX_Parm6;
         A9vendedorID = (short)(NumberUtil.Val( dynvendedorID.CurrentValue, "."));
         dyntipOrdID = dynGX_Parm7;
         A17tipOrdID = (short)(NumberUtil.Val( dyntipOrdID.CurrentValue, "."));
         dynprotID = dynGX_Parm8;
         A10protID = (short)(NumberUtil.Val( dynprotID.CurrentValue, "."));
         GXAORDENMARCAID_html0H16( AV10EmpID) ;
         GXAORDENMODELOID_html0H16( AV10EmpID, AV22MarcaID) ;
         GXACLIENTEID_html0H16( AV10EmpID) ;
         GXAVENDEDORID_html0H16( AV10EmpID) ;
         GXATIPORDID_html0H16( AV10EmpID) ;
         GXAPROTID_html0H16( AV10EmpID) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         dynOrdenMarcaID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0));
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         dynClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0));
         dynvendedorID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0));
         dyntipOrdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0));
         dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
         if ( dynOrdenMarcaID.ItemCount > 0 )
         {
            A26OrdenMarcaID = (short)(NumberUtil.Val( dynOrdenMarcaID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0))), "."));
         }
         dynOrdenMarcaID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A26OrdenMarcaID), 4, 0));
         isValidOutput.Add(dynOrdenMarcaID);
         if ( dynOrdenModeloID.ItemCount > 0 )
         {
            A117OrdenModeloID = (short)(NumberUtil.Val( dynOrdenModeloID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0))), "."));
         }
         dynOrdenModeloID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A117OrdenModeloID), 4, 0));
         isValidOutput.Add(dynOrdenModeloID);
         if ( dynClienteID.ItemCount > 0 )
         {
            A5ClienteID = (short)(NumberUtil.Val( dynClienteID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0))), "."));
         }
         dynClienteID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A5ClienteID), 4, 0));
         isValidOutput.Add(dynClienteID);
         if ( dynvendedorID.ItemCount > 0 )
         {
            A9vendedorID = (short)(NumberUtil.Val( dynvendedorID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0))), "."));
         }
         dynvendedorID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9vendedorID), 4, 0));
         isValidOutput.Add(dynvendedorID);
         if ( dyntipOrdID.ItemCount > 0 )
         {
            A17tipOrdID = (short)(NumberUtil.Val( dyntipOrdID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0))), "."));
         }
         dyntipOrdID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A17tipOrdID), 4, 0));
         isValidOutput.Add(dyntipOrdID);
         if ( dynprotID.ItemCount > 0 )
         {
            A10protID = (short)(NumberUtil.Val( dynprotID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0))), "."));
         }
         dynprotID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A10protID), 4, 0));
         isValidOutput.Add(dynprotID);
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
         /* Using cursor T000H82 */
         pr_default.execute(76, new Object[] {A1EmpID, A36detTipoProdID});
         if ( (pr_default.getStatus(76) == 101) )
         {
            GX_msglist.addItem("No existe 'Tipo Producto'.", "ForeignKeyNotFound", 1, "DETTIPOPRODID");
            AnyError = 1;
            GX_FocusControl = dyndetTipoProdID_Internalname;
         }
         pr_default.close(76);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
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
                                 String GX_Parm3 )
      {
         A1EmpID = GX_Parm1;
         dyncategID = dynGX_Parm2;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         A146categDsc = GX_Parm3;
         n146categDsc = false;
         /* Using cursor T000H83 */
         pr_default.execute(77, new Object[] {A1EmpID, A32categID});
         if ( (pr_default.getStatus(77) == 101) )
         {
            GX_msglist.addItem("No existe 'Categorias'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
         }
         A146categDsc = T000H83_A146categDsc[0];
         n146categDsc = T000H83_n146categDsc[0];
         pr_default.close(77);
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
                                  GXCombobox dynGX_Parm2 ,
                                  short GX_Parm3 ,
                                  String GX_Parm4 ,
                                  decimal GX_Parm5 )
      {
         A1EmpID = GX_Parm1;
         dyncategID = dynGX_Parm2;
         A32categID = (short)(NumberUtil.Val( dyncategID.CurrentValue, "."));
         A33subCatID = GX_Parm3;
         A148subCatDsc = GX_Parm4;
         n148subCatDsc = false;
         A150subCatPrec = GX_Parm5;
         n150subCatPrec = false;
         /* Using cursor T000H84 */
         pr_default.execute(78, new Object[] {A1EmpID, A32categID, A33subCatID});
         if ( (pr_default.getStatus(78) == 101) )
         {
            GX_msglist.addItem("No existe 'sub Cat'.", "ForeignKeyNotFound", 1, "CATEGID");
            AnyError = 1;
            GX_FocusControl = dyncategID_Internalname;
         }
         A148subCatDsc = T000H84_A148subCatDsc[0];
         n148subCatDsc = T000H84_n148subCatDsc[0];
         A150subCatPrec = T000H84_A150subCatPrec[0];
         n150subCatPrec = T000H84_n150subCatPrec[0];
         pr_default.close(78);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV27OrdenPeriodo',fld:'vORDENPERIODO',pic:'Z9',hsh:true},{av:'AV25OrdenAnio',fld:'vORDENANIO',pic:'ZZZ9',hsh:true},{av:'AV26OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("ENTER",",oparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV9ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV27OrdenPeriodo',fld:'vORDENPERIODO',pic:'Z9',hsh:true},{av:'AV25OrdenAnio',fld:'vORDENANIO',pic:'ZZZ9',hsh:true},{av:'AV26OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV19Insert_VehiculoID',fld:'vINSERT_VEHICULOID',pic:'ZZZ9'},{av:'AV15Insert_OrdenMarcaID',fld:'vINSERT_ORDENMARCAID',pic:'ZZZ9'},{av:'AV18Insert_tipOrdID',fld:'vINSERT_TIPORDID',pic:'ZZZ9'},{av:'AV20Insert_vendedorID',fld:'vINSERT_VENDEDORID',pic:'ZZZ9'},{av:'AV17Insert_protID',fld:'vINSERT_PROTID',pic:'ZZZ9'},{av:'A116OrdenUser',fld:'ORDENUSER',pic:'@!'},{av:'A203ordenNroPed',fld:'ORDENNROPED',pic:'ZZZZZZZ9'},{av:'A166OrdenValPint',fld:'ORDENVALPINT',pic:'ZZZZZ9.999'},{av:'A167OrdenValEstr',fld:'ORDENVALESTR',pic:'ZZZZZ9.999'},{av:'A168OrdenValOtrs',fld:'ORDENVALOTRS',pic:'ZZZZZ9.999'},{av:'A192OrdenPed',fld:'ORDENPED',pic:'ZZZZZZZ9'},{av:'AV11facEmp',fld:'vFACEMP',pic:'ZZZ9'},{av:'AV43ordenDesp',fld:'vORDENDESP',pic:'Z9'},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("AFTER TRN","{handler:'E120H2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV29TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'AV7ageID',fld:'vAGEID',pic:'ZZZ9',hsh:true},{av:'AV25OrdenAnio',fld:'vORDENANIO',pic:'ZZZ9',hsh:true},{av:'cmbOrdenPeriodo'},{av:'A24OrdenPeriodo',fld:'ORDENPERIODO',pic:'Z9'},{av:'A22OrdenID',fld:'ORDENID',pic:'ZZZ9'},{av:'A401OrdenNroDesp',fld:'ORDENNRODESP',pic:'ZZZZZ9'},{av:'AV27OrdenPeriodo',fld:'vORDENPERIODO',pic:'Z9',hsh:true},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("AFTER TRN",",oparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("ORDENPROCESO.CLICK","{handler:'E130H2',iparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("ORDENPROCESO.CLICK",",oparms:[{av:'A172OrdenfchEnt',fld:'ORDENFCHENT',pic:''},{av:'edtOrdenfchEnt_Visible',ctrl:'ORDENFCHENT',prop:'Visible'},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("CLIENTEID.CLICK","{handler:'E140H2',iparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("CLIENTEID.CLICK",",oparms:[{av:'A195OrdenFacNomb',fld:'ORDENFACNOMB',pic:'@!'},{av:'edtOrdenFacNomb_Visible',ctrl:'ORDENFACNOMB',prop:'Visible'},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("'EXEXCEL'","{handler:'E150H2',iparms:[{av:'AV9ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV27OrdenPeriodo',fld:'vORDENPERIODO',pic:'Z9',hsh:true},{av:'AV25OrdenAnio',fld:'vORDENANIO',pic:'ZZZ9',hsh:true},{av:'AV26OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'AV37ErrorMessage',fld:'vERRORMESSAGE',pic:''},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("'EXEXCEL'",",oparms:[{av:'AV40errorMesjTool',fld:'vERRORMESJTOOL',pic:''},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
         setEventMetadata("'EXPORTPDF'","{handler:'E160H2',iparms:[{av:'AV9ClienteID',fld:'vCLIENTEID',pic:'ZZZ9',hsh:true},{av:'AV27OrdenPeriodo',fld:'vORDENPERIODO',pic:'Z9',hsh:true},{av:'AV25OrdenAnio',fld:'vORDENANIO',pic:'ZZZ9',hsh:true},{av:'AV26OrdenID',fld:'vORDENID',pic:'ZZZ9',hsh:true},{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]");
         setEventMetadata("'EXPORTPDF'",",oparms:[{av:'dynavUsucod'},{av:'AV33usuCod',fld:'vUSUCOD',pic:'',hsh:true},{av:'dynOrdenProceso'},{av:'A133OrdenProceso',fld:'ORDENPROCESO',pic:'@!'},{av:'dynOrdenEmpFac'},{av:'A132OrdenEmpFac',fld:'ORDENEMPFAC',pic:'ZZZ9'},{av:'AV10EmpID',fld:'vEMPID',pic:'ZZZ9',hsh:true},{av:'dynOrdenMarcaID'},{av:'A26OrdenMarcaID',fld:'ORDENMARCAID',pic:'ZZZ9'},{av:'AV22MarcaID',fld:'vMARCAID',pic:'ZZZ9'},{av:'dynOrdenModeloID'},{av:'A117OrdenModeloID',fld:'ORDENMODELOID',pic:'ZZZ9'},{av:'dynClienteID'},{av:'A5ClienteID',fld:'CLIENTEID',pic:'ZZZ9'},{av:'dynvendedorID'},{av:'A9vendedorID',fld:'VENDEDORID',pic:'ZZZ9'},{av:'dyntipOrdID'},{av:'A17tipOrdID',fld:'TIPORDID',pic:'ZZZ9'},{av:'dynprotID'},{av:'A10protID',fld:'PROTID',pic:'ZZZ9'}]}");
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
         pr_default.close(76);
         pr_default.close(77);
         pr_default.close(59);
         pr_default.close(78);
         pr_default.close(60);
         pr_default.close(7);
         pr_default.close(9);
         pr_default.close(37);
         pr_default.close(38);
         pr_default.close(75);
         pr_default.close(74);
         pr_default.close(40);
         pr_default.close(42);
         pr_default.close(43);
         pr_default.close(41);
         pr_default.close(39);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV33usuCod = "";
         Z116OrdenUser = "";
         Z115OrdenEst = "";
         Z119OrdenFch = DateTime.MinValue;
         Z107representane = "";
         Z109fchVenta = DateTime.MinValue;
         Z133OrdenProceso = "";
         Z172OrdenfchEnt = DateTime.MinValue;
         Z195OrdenFacNomb = "";
         Z253OrdenObreManObra = "";
         Z251OrdenDetDetalle = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A133OrdenProceso = "";
         A115OrdenEst = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A119OrdenFch = DateTime.MinValue;
         A172OrdenfchEnt = DateTime.MinValue;
         sImgUrl = "";
         A44empdsc = "";
         A195OrdenFacNomb = "";
         A107representane = "";
         A68VehiculoPlaca = "";
         A69VehiculoChasis = "";
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         A152OrdenPdf = "";
         A109fchVenta = DateTime.MinValue;
         A153OrdenActaPdf = "";
         lblItems_title_Jsonclick = "";
         AV40errorMesjTool = "";
         bttButton3_Jsonclick = "";
         bttButton1_Jsonclick = "";
         lblCosteomatprim_title_Jsonclick = "";
         lblManoobra_title_Jsonclick = "";
         lblTotalrenta_title_Jsonclick = "";
         bttBtnenter2_Jsonclick = "";
         bttButton2_Jsonclick = "";
         GriditemsopContainer = new GXWebGrid( context);
         GriditemsopColumn = new GXWebColumn();
         A146categDsc = "";
         A148subCatDsc = "";
         A251OrdenDetDetalle = "";
         sMode17 = "";
         sStyleString = "";
         Grid1Container = new GXWebGrid( context);
         Grid1Column = new GXWebColumn();
         A253OrdenObreManObra = "";
         sMode52 = "";
         A116OrdenUser = "";
         A108urlPdf = "";
         A112documento = "";
         A57ClienteDsc = "";
         A72vendedorDsc = "";
         A74protDsc = "";
         A104tipOrdDsc = "";
         AV46Pgmname = "";
         A242ObrePrApellido = "";
         A243ObreSegApellido = "";
         A240ObrePrNombre = "";
         A241ObreSegNombre = "";
         A244ObreNombre = "";
         Tabcosteo_Objectcall = "";
         Tabcosteo_Activepagecontrolname = "";
         GXCCtlgxBlob = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode16 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV29TrnContext = new SdtTransactionContext(context);
         AV12fechaCtrol = DateTime.MinValue;
         AV28rolUser = "";
         AV35WebSession = context.GetSession();
         AV30TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV36archivo = "";
         GXt_char2 = "";
         AV37ErrorMessage = "";
         Z108urlPdf = "";
         Z112documento = "";
         Z152OrdenPdf = "";
         Z153OrdenActaPdf = "";
         Z44empdsc = "";
         Z57ClienteDsc = "";
         Z68VehiculoPlaca = "";
         Z69VehiculoChasis = "";
         Z104tipOrdDsc = "";
         Z72vendedorDsc = "";
         Z74protDsc = "";
         T000H12_A44empdsc = new String[] {""} ;
         T000H12_n44empdsc = new bool[] {false} ;
         T000H13_A57ClienteDsc = new String[] {""} ;
         T000H13_n57ClienteDsc = new bool[] {false} ;
         T000H16_A72vendedorDsc = new String[] {""} ;
         T000H16_n72vendedorDsc = new bool[] {false} ;
         T000H17_A74protDsc = new String[] {""} ;
         T000H17_n74protDsc = new bool[] {false} ;
         T000H18_A104tipOrdDsc = new String[] {""} ;
         T000H18_n104tipOrdDsc = new bool[] {false} ;
         T000H15_A68VehiculoPlaca = new String[] {""} ;
         T000H15_n68VehiculoPlaca = new bool[] {false} ;
         T000H15_A69VehiculoChasis = new String[] {""} ;
         T000H15_n69VehiculoChasis = new bool[] {false} ;
         T000H21_A255OrdenObreSuma = new decimal[1] ;
         T000H21_n255OrdenObreSuma = new bool[] {false} ;
         T000H23_A24OrdenPeriodo = new short[1] ;
         T000H23_A25OrdenAnio = new short[1] ;
         T000H23_A22OrdenID = new short[1] ;
         T000H23_A116OrdenUser = new String[] {""} ;
         T000H23_n116OrdenUser = new bool[] {false} ;
         T000H23_A115OrdenEst = new String[] {""} ;
         T000H23_n115OrdenEst = new bool[] {false} ;
         T000H23_A44empdsc = new String[] {""} ;
         T000H23_n44empdsc = new bool[] {false} ;
         T000H23_A57ClienteDsc = new String[] {""} ;
         T000H23_n57ClienteDsc = new bool[] {false} ;
         T000H23_A68VehiculoPlaca = new String[] {""} ;
         T000H23_n68VehiculoPlaca = new bool[] {false} ;
         T000H23_A69VehiculoChasis = new String[] {""} ;
         T000H23_n69VehiculoChasis = new bool[] {false} ;
         T000H23_A117OrdenModeloID = new short[1] ;
         T000H23_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         T000H23_n119OrdenFch = new bool[] {false} ;
         T000H23_A104tipOrdDsc = new String[] {""} ;
         T000H23_n104tipOrdDsc = new bool[] {false} ;
         T000H23_A72vendedorDsc = new String[] {""} ;
         T000H23_n72vendedorDsc = new bool[] {false} ;
         T000H23_A106facturaNro = new int[1] ;
         T000H23_n106facturaNro = new bool[] {false} ;
         T000H23_A107representane = new String[] {""} ;
         T000H23_n107representane = new bool[] {false} ;
         T000H23_A203ordenNroPed = new int[1] ;
         T000H23_n203ordenNroPed = new bool[] {false} ;
         T000H23_A74protDsc = new String[] {""} ;
         T000H23_n74protDsc = new bool[] {false} ;
         T000H23_A109fchVenta = new DateTime[] {DateTime.MinValue} ;
         T000H23_n109fchVenta = new bool[] {false} ;
         T000H23_A110cantDias = new short[1] ;
         T000H23_n110cantDias = new bool[] {false} ;
         T000H23_A132OrdenEmpFac = new short[1] ;
         T000H23_n132OrdenEmpFac = new bool[] {false} ;
         T000H23_A133OrdenProceso = new String[] {""} ;
         T000H23_n133OrdenProceso = new bool[] {false} ;
         T000H23_A161OrdenSubtotal = new decimal[1] ;
         T000H23_n161OrdenSubtotal = new bool[] {false} ;
         T000H23_A162OrdenValInds = new decimal[1] ;
         T000H23_n162OrdenValInds = new bool[] {false} ;
         T000H23_A163OrdenValEnrq = new decimal[1] ;
         T000H23_n163OrdenValEnrq = new bool[] {false} ;
         T000H23_A165OrdenValCal = new decimal[1] ;
         T000H23_n165OrdenValCal = new bool[] {false} ;
         T000H23_A166OrdenValPint = new decimal[1] ;
         T000H23_n166OrdenValPint = new bool[] {false} ;
         T000H23_A167OrdenValEstr = new decimal[1] ;
         T000H23_n167OrdenValEstr = new bool[] {false} ;
         T000H23_A168OrdenValOtrs = new decimal[1] ;
         T000H23_n168OrdenValOtrs = new bool[] {false} ;
         T000H23_A172OrdenfchEnt = new DateTime[] {DateTime.MinValue} ;
         T000H23_n172OrdenfchEnt = new bool[] {false} ;
         T000H23_A192OrdenPed = new int[1] ;
         T000H23_n192OrdenPed = new bool[] {false} ;
         T000H23_A195OrdenFacNomb = new String[] {""} ;
         T000H23_n195OrdenFacNomb = new bool[] {false} ;
         T000H23_A210OrdenUltSec = new short[1] ;
         T000H23_n210OrdenUltSec = new bool[] {false} ;
         T000H23_A401OrdenNroDesp = new int[1] ;
         T000H23_n401OrdenNroDesp = new bool[] {false} ;
         T000H23_A1EmpID = new short[1] ;
         T000H23_A5ClienteID = new short[1] ;
         T000H23_A26OrdenMarcaID = new short[1] ;
         T000H23_A8VehiculoID = new short[1] ;
         T000H23_A9vendedorID = new short[1] ;
         T000H23_A10protID = new short[1] ;
         T000H23_A17tipOrdID = new short[1] ;
         T000H23_A255OrdenObreSuma = new decimal[1] ;
         T000H23_n255OrdenObreSuma = new bool[] {false} ;
         T000H23_A108urlPdf = new String[] {""} ;
         T000H23_n108urlPdf = new bool[] {false} ;
         T000H23_A112documento = new String[] {""} ;
         T000H23_n112documento = new bool[] {false} ;
         T000H23_A152OrdenPdf = new String[] {""} ;
         T000H23_n152OrdenPdf = new bool[] {false} ;
         T000H23_A153OrdenActaPdf = new String[] {""} ;
         T000H23_n153OrdenActaPdf = new bool[] {false} ;
         T000H14_A6MarcaID = new short[1] ;
         T000H24_A44empdsc = new String[] {""} ;
         T000H24_n44empdsc = new bool[] {false} ;
         T000H25_A68VehiculoPlaca = new String[] {""} ;
         T000H25_n68VehiculoPlaca = new bool[] {false} ;
         T000H25_A69VehiculoChasis = new String[] {""} ;
         T000H25_n69VehiculoChasis = new bool[] {false} ;
         T000H26_A72vendedorDsc = new String[] {""} ;
         T000H26_n72vendedorDsc = new bool[] {false} ;
         T000H27_A74protDsc = new String[] {""} ;
         T000H27_n74protDsc = new bool[] {false} ;
         T000H28_A104tipOrdDsc = new String[] {""} ;
         T000H28_n104tipOrdDsc = new bool[] {false} ;
         T000H29_A57ClienteDsc = new String[] {""} ;
         T000H29_n57ClienteDsc = new bool[] {false} ;
         T000H31_A255OrdenObreSuma = new decimal[1] ;
         T000H31_n255OrdenObreSuma = new bool[] {false} ;
         T000H32_A1EmpID = new short[1] ;
         T000H32_A5ClienteID = new short[1] ;
         T000H32_A24OrdenPeriodo = new short[1] ;
         T000H32_A25OrdenAnio = new short[1] ;
         T000H32_A22OrdenID = new short[1] ;
         T000H11_A24OrdenPeriodo = new short[1] ;
         T000H11_A25OrdenAnio = new short[1] ;
         T000H11_A22OrdenID = new short[1] ;
         T000H11_A116OrdenUser = new String[] {""} ;
         T000H11_n116OrdenUser = new bool[] {false} ;
         T000H11_A115OrdenEst = new String[] {""} ;
         T000H11_n115OrdenEst = new bool[] {false} ;
         T000H11_A117OrdenModeloID = new short[1] ;
         T000H11_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         T000H11_n119OrdenFch = new bool[] {false} ;
         T000H11_A106facturaNro = new int[1] ;
         T000H11_n106facturaNro = new bool[] {false} ;
         T000H11_A107representane = new String[] {""} ;
         T000H11_n107representane = new bool[] {false} ;
         T000H11_A203ordenNroPed = new int[1] ;
         T000H11_n203ordenNroPed = new bool[] {false} ;
         T000H11_A109fchVenta = new DateTime[] {DateTime.MinValue} ;
         T000H11_n109fchVenta = new bool[] {false} ;
         T000H11_A110cantDias = new short[1] ;
         T000H11_n110cantDias = new bool[] {false} ;
         T000H11_A132OrdenEmpFac = new short[1] ;
         T000H11_n132OrdenEmpFac = new bool[] {false} ;
         T000H11_A133OrdenProceso = new String[] {""} ;
         T000H11_n133OrdenProceso = new bool[] {false} ;
         T000H11_A161OrdenSubtotal = new decimal[1] ;
         T000H11_n161OrdenSubtotal = new bool[] {false} ;
         T000H11_A162OrdenValInds = new decimal[1] ;
         T000H11_n162OrdenValInds = new bool[] {false} ;
         T000H11_A163OrdenValEnrq = new decimal[1] ;
         T000H11_n163OrdenValEnrq = new bool[] {false} ;
         T000H11_A165OrdenValCal = new decimal[1] ;
         T000H11_n165OrdenValCal = new bool[] {false} ;
         T000H11_A166OrdenValPint = new decimal[1] ;
         T000H11_n166OrdenValPint = new bool[] {false} ;
         T000H11_A167OrdenValEstr = new decimal[1] ;
         T000H11_n167OrdenValEstr = new bool[] {false} ;
         T000H11_A168OrdenValOtrs = new decimal[1] ;
         T000H11_n168OrdenValOtrs = new bool[] {false} ;
         T000H11_A172OrdenfchEnt = new DateTime[] {DateTime.MinValue} ;
         T000H11_n172OrdenfchEnt = new bool[] {false} ;
         T000H11_A192OrdenPed = new int[1] ;
         T000H11_n192OrdenPed = new bool[] {false} ;
         T000H11_A195OrdenFacNomb = new String[] {""} ;
         T000H11_n195OrdenFacNomb = new bool[] {false} ;
         T000H11_A210OrdenUltSec = new short[1] ;
         T000H11_n210OrdenUltSec = new bool[] {false} ;
         T000H11_A401OrdenNroDesp = new int[1] ;
         T000H11_n401OrdenNroDesp = new bool[] {false} ;
         T000H11_A1EmpID = new short[1] ;
         T000H11_A5ClienteID = new short[1] ;
         T000H11_A26OrdenMarcaID = new short[1] ;
         T000H11_A8VehiculoID = new short[1] ;
         T000H11_A9vendedorID = new short[1] ;
         T000H11_A10protID = new short[1] ;
         T000H11_A17tipOrdID = new short[1] ;
         T000H11_A108urlPdf = new String[] {""} ;
         T000H11_n108urlPdf = new bool[] {false} ;
         T000H11_A112documento = new String[] {""} ;
         T000H11_n112documento = new bool[] {false} ;
         T000H11_A152OrdenPdf = new String[] {""} ;
         T000H11_n152OrdenPdf = new bool[] {false} ;
         T000H11_A153OrdenActaPdf = new String[] {""} ;
         T000H11_n153OrdenActaPdf = new bool[] {false} ;
         T000H33_A24OrdenPeriodo = new short[1] ;
         T000H33_A25OrdenAnio = new short[1] ;
         T000H33_A22OrdenID = new short[1] ;
         T000H33_A1EmpID = new short[1] ;
         T000H33_A5ClienteID = new short[1] ;
         T000H34_A24OrdenPeriodo = new short[1] ;
         T000H34_A25OrdenAnio = new short[1] ;
         T000H34_A22OrdenID = new short[1] ;
         T000H34_A1EmpID = new short[1] ;
         T000H34_A5ClienteID = new short[1] ;
         T000H10_A24OrdenPeriodo = new short[1] ;
         T000H10_A25OrdenAnio = new short[1] ;
         T000H10_A22OrdenID = new short[1] ;
         T000H10_A116OrdenUser = new String[] {""} ;
         T000H10_n116OrdenUser = new bool[] {false} ;
         T000H10_A115OrdenEst = new String[] {""} ;
         T000H10_n115OrdenEst = new bool[] {false} ;
         T000H10_A117OrdenModeloID = new short[1] ;
         T000H10_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         T000H10_n119OrdenFch = new bool[] {false} ;
         T000H10_A106facturaNro = new int[1] ;
         T000H10_n106facturaNro = new bool[] {false} ;
         T000H10_A107representane = new String[] {""} ;
         T000H10_n107representane = new bool[] {false} ;
         T000H10_A203ordenNroPed = new int[1] ;
         T000H10_n203ordenNroPed = new bool[] {false} ;
         T000H10_A109fchVenta = new DateTime[] {DateTime.MinValue} ;
         T000H10_n109fchVenta = new bool[] {false} ;
         T000H10_A110cantDias = new short[1] ;
         T000H10_n110cantDias = new bool[] {false} ;
         T000H10_A132OrdenEmpFac = new short[1] ;
         T000H10_n132OrdenEmpFac = new bool[] {false} ;
         T000H10_A133OrdenProceso = new String[] {""} ;
         T000H10_n133OrdenProceso = new bool[] {false} ;
         T000H10_A161OrdenSubtotal = new decimal[1] ;
         T000H10_n161OrdenSubtotal = new bool[] {false} ;
         T000H10_A162OrdenValInds = new decimal[1] ;
         T000H10_n162OrdenValInds = new bool[] {false} ;
         T000H10_A163OrdenValEnrq = new decimal[1] ;
         T000H10_n163OrdenValEnrq = new bool[] {false} ;
         T000H10_A165OrdenValCal = new decimal[1] ;
         T000H10_n165OrdenValCal = new bool[] {false} ;
         T000H10_A166OrdenValPint = new decimal[1] ;
         T000H10_n166OrdenValPint = new bool[] {false} ;
         T000H10_A167OrdenValEstr = new decimal[1] ;
         T000H10_n167OrdenValEstr = new bool[] {false} ;
         T000H10_A168OrdenValOtrs = new decimal[1] ;
         T000H10_n168OrdenValOtrs = new bool[] {false} ;
         T000H10_A172OrdenfchEnt = new DateTime[] {DateTime.MinValue} ;
         T000H10_n172OrdenfchEnt = new bool[] {false} ;
         T000H10_A192OrdenPed = new int[1] ;
         T000H10_n192OrdenPed = new bool[] {false} ;
         T000H10_A195OrdenFacNomb = new String[] {""} ;
         T000H10_n195OrdenFacNomb = new bool[] {false} ;
         T000H10_A210OrdenUltSec = new short[1] ;
         T000H10_n210OrdenUltSec = new bool[] {false} ;
         T000H10_A401OrdenNroDesp = new int[1] ;
         T000H10_n401OrdenNroDesp = new bool[] {false} ;
         T000H10_A1EmpID = new short[1] ;
         T000H10_A5ClienteID = new short[1] ;
         T000H10_A26OrdenMarcaID = new short[1] ;
         T000H10_A8VehiculoID = new short[1] ;
         T000H10_A9vendedorID = new short[1] ;
         T000H10_A10protID = new short[1] ;
         T000H10_A17tipOrdID = new short[1] ;
         T000H10_A108urlPdf = new String[] {""} ;
         T000H10_n108urlPdf = new bool[] {false} ;
         T000H10_A112documento = new String[] {""} ;
         T000H10_n112documento = new bool[] {false} ;
         T000H10_A152OrdenPdf = new String[] {""} ;
         T000H10_n152OrdenPdf = new bool[] {false} ;
         T000H10_A153OrdenActaPdf = new String[] {""} ;
         T000H10_n153OrdenActaPdf = new bool[] {false} ;
         T000H42_A44empdsc = new String[] {""} ;
         T000H42_n44empdsc = new bool[] {false} ;
         T000H43_A57ClienteDsc = new String[] {""} ;
         T000H43_n57ClienteDsc = new bool[] {false} ;
         T000H45_A255OrdenObreSuma = new decimal[1] ;
         T000H45_n255OrdenObreSuma = new bool[] {false} ;
         T000H46_A68VehiculoPlaca = new String[] {""} ;
         T000H46_n68VehiculoPlaca = new bool[] {false} ;
         T000H46_A69VehiculoChasis = new String[] {""} ;
         T000H46_n69VehiculoChasis = new bool[] {false} ;
         T000H47_A104tipOrdDsc = new String[] {""} ;
         T000H47_n104tipOrdDsc = new bool[] {false} ;
         T000H48_A72vendedorDsc = new String[] {""} ;
         T000H48_n72vendedorDsc = new bool[] {false} ;
         T000H49_A74protDsc = new String[] {""} ;
         T000H49_n74protDsc = new bool[] {false} ;
         T000H51_A1EmpID = new short[1] ;
         T000H51_A5ClienteID = new short[1] ;
         T000H51_A24OrdenPeriodo = new short[1] ;
         T000H51_A25OrdenAnio = new short[1] ;
         T000H51_A22OrdenID = new short[1] ;
         T000H52_A5ClienteID = new short[1] ;
         T000H52_A24OrdenPeriodo = new short[1] ;
         T000H52_A25OrdenAnio = new short[1] ;
         T000H52_A22OrdenID = new short[1] ;
         T000H52_A252OrdenObrID = new short[1] ;
         T000H52_A238ObreID = new short[1] ;
         T000H52_A253OrdenObreManObra = new String[] {""} ;
         T000H52_n253OrdenObreManObra = new bool[] {false} ;
         T000H52_A254OrdenObreValor = new decimal[1] ;
         T000H52_n254OrdenObreValor = new bool[] {false} ;
         T000H52_A1EmpID = new short[1] ;
         T000H53_A1EmpID = new short[1] ;
         T000H53_A5ClienteID = new short[1] ;
         T000H53_A24OrdenPeriodo = new short[1] ;
         T000H53_A25OrdenAnio = new short[1] ;
         T000H53_A22OrdenID = new short[1] ;
         T000H53_A252OrdenObrID = new short[1] ;
         T000H53_A238ObreID = new short[1] ;
         T000H9_A5ClienteID = new short[1] ;
         T000H9_A24OrdenPeriodo = new short[1] ;
         T000H9_A25OrdenAnio = new short[1] ;
         T000H9_A22OrdenID = new short[1] ;
         T000H9_A252OrdenObrID = new short[1] ;
         T000H9_A238ObreID = new short[1] ;
         T000H9_A253OrdenObreManObra = new String[] {""} ;
         T000H9_n253OrdenObreManObra = new bool[] {false} ;
         T000H9_A254OrdenObreValor = new decimal[1] ;
         T000H9_n254OrdenObreValor = new bool[] {false} ;
         T000H9_A1EmpID = new short[1] ;
         T000H8_A5ClienteID = new short[1] ;
         T000H8_A24OrdenPeriodo = new short[1] ;
         T000H8_A25OrdenAnio = new short[1] ;
         T000H8_A22OrdenID = new short[1] ;
         T000H8_A252OrdenObrID = new short[1] ;
         T000H8_A238ObreID = new short[1] ;
         T000H8_A253OrdenObreManObra = new String[] {""} ;
         T000H8_n253OrdenObreManObra = new bool[] {false} ;
         T000H8_A254OrdenObreValor = new decimal[1] ;
         T000H8_n254OrdenObreValor = new bool[] {false} ;
         T000H8_A1EmpID = new short[1] ;
         T000H57_A1EmpID = new short[1] ;
         T000H57_A5ClienteID = new short[1] ;
         T000H57_A24OrdenPeriodo = new short[1] ;
         T000H57_A25OrdenAnio = new short[1] ;
         T000H57_A22OrdenID = new short[1] ;
         T000H57_A252OrdenObrID = new short[1] ;
         T000H57_A238ObreID = new short[1] ;
         Z146categDsc = "";
         Z148subCatDsc = "";
         T000H5_A146categDsc = new String[] {""} ;
         T000H5_n146categDsc = new bool[] {false} ;
         T000H58_A5ClienteID = new short[1] ;
         T000H58_A24OrdenPeriodo = new short[1] ;
         T000H58_A25OrdenAnio = new short[1] ;
         T000H58_A22OrdenID = new short[1] ;
         T000H58_A41OrdenSecId = new short[1] ;
         T000H58_A146categDsc = new String[] {""} ;
         T000H58_n146categDsc = new bool[] {false} ;
         T000H58_A148subCatDsc = new String[] {""} ;
         T000H58_n148subCatDsc = new bool[] {false} ;
         T000H58_A150subCatPrec = new decimal[1] ;
         T000H58_n150subCatPrec = new bool[] {false} ;
         T000H58_A208OrdenDetCant = new decimal[1] ;
         T000H58_n208OrdenDetCant = new bool[] {false} ;
         T000H58_A251OrdenDetDetalle = new String[] {""} ;
         T000H58_n251OrdenDetDetalle = new bool[] {false} ;
         T000H58_A396OrdenDetDesp = new short[1] ;
         T000H58_n396OrdenDetDesp = new bool[] {false} ;
         T000H58_A397OrdenDesp = new short[1] ;
         T000H58_n397OrdenDesp = new bool[] {false} ;
         T000H58_A1EmpID = new short[1] ;
         T000H58_A36detTipoProdID = new short[1] ;
         T000H58_A32categID = new short[1] ;
         T000H58_A33subCatID = new short[1] ;
         T000H4_A31tipoProdID = new short[1] ;
         T000H6_A148subCatDsc = new String[] {""} ;
         T000H6_n148subCatDsc = new bool[] {false} ;
         T000H6_A150subCatPrec = new decimal[1] ;
         T000H6_n150subCatPrec = new bool[] {false} ;
         T000H59_A146categDsc = new String[] {""} ;
         T000H59_n146categDsc = new bool[] {false} ;
         T000H60_A148subCatDsc = new String[] {""} ;
         T000H60_n148subCatDsc = new bool[] {false} ;
         T000H60_A150subCatPrec = new decimal[1] ;
         T000H60_n150subCatPrec = new bool[] {false} ;
         T000H61_A1EmpID = new short[1] ;
         T000H61_A5ClienteID = new short[1] ;
         T000H61_A24OrdenPeriodo = new short[1] ;
         T000H61_A25OrdenAnio = new short[1] ;
         T000H61_A22OrdenID = new short[1] ;
         T000H61_A41OrdenSecId = new short[1] ;
         T000H3_A5ClienteID = new short[1] ;
         T000H3_A24OrdenPeriodo = new short[1] ;
         T000H3_A25OrdenAnio = new short[1] ;
         T000H3_A22OrdenID = new short[1] ;
         T000H3_A41OrdenSecId = new short[1] ;
         T000H3_A208OrdenDetCant = new decimal[1] ;
         T000H3_n208OrdenDetCant = new bool[] {false} ;
         T000H3_A251OrdenDetDetalle = new String[] {""} ;
         T000H3_n251OrdenDetDetalle = new bool[] {false} ;
         T000H3_A396OrdenDetDesp = new short[1] ;
         T000H3_n396OrdenDetDesp = new bool[] {false} ;
         T000H3_A397OrdenDesp = new short[1] ;
         T000H3_n397OrdenDesp = new bool[] {false} ;
         T000H3_A1EmpID = new short[1] ;
         T000H3_A36detTipoProdID = new short[1] ;
         T000H3_A32categID = new short[1] ;
         T000H3_A33subCatID = new short[1] ;
         T000H2_A5ClienteID = new short[1] ;
         T000H2_A24OrdenPeriodo = new short[1] ;
         T000H2_A25OrdenAnio = new short[1] ;
         T000H2_A22OrdenID = new short[1] ;
         T000H2_A41OrdenSecId = new short[1] ;
         T000H2_A208OrdenDetCant = new decimal[1] ;
         T000H2_n208OrdenDetCant = new bool[] {false} ;
         T000H2_A251OrdenDetDetalle = new String[] {""} ;
         T000H2_n251OrdenDetDetalle = new bool[] {false} ;
         T000H2_A396OrdenDetDesp = new short[1] ;
         T000H2_n396OrdenDetDesp = new bool[] {false} ;
         T000H2_A397OrdenDesp = new short[1] ;
         T000H2_n397OrdenDesp = new bool[] {false} ;
         T000H2_A1EmpID = new short[1] ;
         T000H2_A36detTipoProdID = new short[1] ;
         T000H2_A32categID = new short[1] ;
         T000H2_A33subCatID = new short[1] ;
         T000H65_A146categDsc = new String[] {""} ;
         T000H65_n146categDsc = new bool[] {false} ;
         T000H66_A148subCatDsc = new String[] {""} ;
         T000H66_n148subCatDsc = new bool[] {false} ;
         T000H66_A150subCatPrec = new decimal[1] ;
         T000H66_n150subCatPrec = new bool[] {false} ;
         T000H67_A1EmpID = new short[1] ;
         T000H67_A5ClienteID = new short[1] ;
         T000H67_A24OrdenPeriodo = new short[1] ;
         T000H67_A25OrdenAnio = new short[1] ;
         T000H67_A22OrdenID = new short[1] ;
         T000H67_A41OrdenSecId = new short[1] ;
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         ROClassString = "";
         GriditemsopRow = new GXWebRow();
         subGriditemsop_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i115OrdenEst = "";
         i116OrdenUser = "";
         i119OrdenFch = DateTime.MinValue;
         i133OrdenProceso = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000H68_A3UsuCod = new String[] {""} ;
         T000H68_A398UsuAlias = new String[] {""} ;
         T000H68_n398UsuAlias = new bool[] {false} ;
         T000H69_A20ProcID = new short[1] ;
         T000H69_A129ProcAbre = new String[] {""} ;
         T000H69_n129ProcAbre = new bool[] {false} ;
         T000H69_A128ProcDsc = new String[] {""} ;
         T000H69_n128ProcDsc = new bool[] {false} ;
         T000H70_A1EmpID = new short[1] ;
         T000H70_A44empdsc = new String[] {""} ;
         T000H70_n44empdsc = new bool[] {false} ;
         T000H70_A45EmpEst = new String[] {""} ;
         T000H70_n45EmpEst = new bool[] {false} ;
         T000H71_A1EmpID = new short[1] ;
         T000H71_A6MarcaID = new short[1] ;
         T000H71_A62MarcaDsc = new String[] {""} ;
         T000H71_n62MarcaDsc = new bool[] {false} ;
         T000H72_A1EmpID = new short[1] ;
         T000H72_A6MarcaID = new short[1] ;
         T000H72_A7ModeloID = new short[1] ;
         T000H72_A64ModeloDsc = new String[] {""} ;
         T000H72_n64ModeloDsc = new bool[] {false} ;
         T000H73_A1EmpID = new short[1] ;
         T000H73_A5ClienteID = new short[1] ;
         T000H73_A57ClienteDsc = new String[] {""} ;
         T000H73_n57ClienteDsc = new bool[] {false} ;
         T000H74_A1EmpID = new short[1] ;
         T000H74_A9vendedorID = new short[1] ;
         T000H74_A72vendedorDsc = new String[] {""} ;
         T000H74_n72vendedorDsc = new bool[] {false} ;
         T000H74_A73vendedorEst = new String[] {""} ;
         T000H74_n73vendedorEst = new bool[] {false} ;
         T000H75_A1EmpID = new short[1] ;
         T000H75_A17tipOrdID = new short[1] ;
         T000H75_A104tipOrdDsc = new String[] {""} ;
         T000H75_n104tipOrdDsc = new bool[] {false} ;
         T000H76_A1EmpID = new short[1] ;
         T000H76_A10protID = new short[1] ;
         T000H76_A74protDsc = new String[] {""} ;
         T000H76_n74protDsc = new bool[] {false} ;
         T000H77_A239ObreCedula = new String[] {""} ;
         T000H77_A238ObreID = new short[1] ;
         T000H77_A244ObreNombre = new String[] {""} ;
         T000H78_A1EmpID = new short[1] ;
         T000H78_A31tipoProdID = new short[1] ;
         T000H78_A144tipoProdDsc = new String[] {""} ;
         T000H78_n144tipoProdDsc = new bool[] {false} ;
         T000H79_A1EmpID = new short[1] ;
         T000H79_A32categID = new short[1] ;
         T000H79_A146categDsc = new String[] {""} ;
         T000H79_n146categDsc = new bool[] {false} ;
         T000H79_A31tipoProdID = new short[1] ;
         T000H80_A6MarcaID = new short[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         T000H81_A6MarcaID = new short[1] ;
         T000H82_A31tipoProdID = new short[1] ;
         T000H83_A146categDsc = new String[] {""} ;
         T000H83_n146categDsc = new bool[] {false} ;
         T000H84_A148subCatDsc = new String[] {""} ;
         T000H84_n148subCatDsc = new bool[] {false} ;
         T000H84_A150subCatPrec = new decimal[1] ;
         T000H84_n150subCatPrec = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ordenproduccion__default(),
            new Object[][] {
                new Object[] {
               T000H2_A5ClienteID, T000H2_A24OrdenPeriodo, T000H2_A25OrdenAnio, T000H2_A22OrdenID, T000H2_A41OrdenSecId, T000H2_A208OrdenDetCant, T000H2_n208OrdenDetCant, T000H2_A251OrdenDetDetalle, T000H2_n251OrdenDetDetalle, T000H2_A396OrdenDetDesp,
               T000H2_n396OrdenDetDesp, T000H2_A397OrdenDesp, T000H2_n397OrdenDesp, T000H2_A1EmpID, T000H2_A36detTipoProdID, T000H2_A32categID, T000H2_A33subCatID
               }
               , new Object[] {
               T000H3_A5ClienteID, T000H3_A24OrdenPeriodo, T000H3_A25OrdenAnio, T000H3_A22OrdenID, T000H3_A41OrdenSecId, T000H3_A208OrdenDetCant, T000H3_n208OrdenDetCant, T000H3_A251OrdenDetDetalle, T000H3_n251OrdenDetDetalle, T000H3_A396OrdenDetDesp,
               T000H3_n396OrdenDetDesp, T000H3_A397OrdenDesp, T000H3_n397OrdenDesp, T000H3_A1EmpID, T000H3_A36detTipoProdID, T000H3_A32categID, T000H3_A33subCatID
               }
               , new Object[] {
               T000H4_A31tipoProdID
               }
               , new Object[] {
               T000H5_A146categDsc, T000H5_n146categDsc
               }
               , new Object[] {
               T000H6_A148subCatDsc, T000H6_n148subCatDsc, T000H6_A150subCatPrec, T000H6_n150subCatPrec
               }
               , new Object[] {
               T000H7_A31tipoProdID
               }
               , new Object[] {
               T000H8_A5ClienteID, T000H8_A24OrdenPeriodo, T000H8_A25OrdenAnio, T000H8_A22OrdenID, T000H8_A252OrdenObrID, T000H8_A238ObreID, T000H8_A253OrdenObreManObra, T000H8_n253OrdenObreManObra, T000H8_A254OrdenObreValor, T000H8_n254OrdenObreValor,
               T000H8_A1EmpID
               }
               , new Object[] {
               T000H9_A5ClienteID, T000H9_A24OrdenPeriodo, T000H9_A25OrdenAnio, T000H9_A22OrdenID, T000H9_A252OrdenObrID, T000H9_A238ObreID, T000H9_A253OrdenObreManObra, T000H9_n253OrdenObreManObra, T000H9_A254OrdenObreValor, T000H9_n254OrdenObreValor,
               T000H9_A1EmpID
               }
               , new Object[] {
               T000H10_A24OrdenPeriodo, T000H10_A25OrdenAnio, T000H10_A22OrdenID, T000H10_A116OrdenUser, T000H10_n116OrdenUser, T000H10_A115OrdenEst, T000H10_n115OrdenEst, T000H10_A117OrdenModeloID, T000H10_A119OrdenFch, T000H10_n119OrdenFch,
               T000H10_A106facturaNro, T000H10_n106facturaNro, T000H10_A107representane, T000H10_n107representane, T000H10_A203ordenNroPed, T000H10_n203ordenNroPed, T000H10_A109fchVenta, T000H10_n109fchVenta, T000H10_A110cantDias, T000H10_n110cantDias,
               T000H10_A132OrdenEmpFac, T000H10_n132OrdenEmpFac, T000H10_A133OrdenProceso, T000H10_n133OrdenProceso, T000H10_A161OrdenSubtotal, T000H10_n161OrdenSubtotal, T000H10_A162OrdenValInds, T000H10_n162OrdenValInds, T000H10_A163OrdenValEnrq, T000H10_n163OrdenValEnrq,
               T000H10_A165OrdenValCal, T000H10_n165OrdenValCal, T000H10_A166OrdenValPint, T000H10_n166OrdenValPint, T000H10_A167OrdenValEstr, T000H10_n167OrdenValEstr, T000H10_A168OrdenValOtrs, T000H10_n168OrdenValOtrs, T000H10_A172OrdenfchEnt, T000H10_n172OrdenfchEnt,
               T000H10_A192OrdenPed, T000H10_n192OrdenPed, T000H10_A195OrdenFacNomb, T000H10_n195OrdenFacNomb, T000H10_A210OrdenUltSec, T000H10_n210OrdenUltSec, T000H10_A401OrdenNroDesp, T000H10_n401OrdenNroDesp, T000H10_A1EmpID, T000H10_A5ClienteID,
               T000H10_A26OrdenMarcaID, T000H10_A8VehiculoID, T000H10_A9vendedorID, T000H10_A10protID, T000H10_A17tipOrdID, T000H10_A108urlPdf, T000H10_n108urlPdf, T000H10_A112documento, T000H10_n112documento, T000H10_A152OrdenPdf,
               T000H10_n152OrdenPdf, T000H10_A153OrdenActaPdf, T000H10_n153OrdenActaPdf
               }
               , new Object[] {
               T000H11_A24OrdenPeriodo, T000H11_A25OrdenAnio, T000H11_A22OrdenID, T000H11_A116OrdenUser, T000H11_n116OrdenUser, T000H11_A115OrdenEst, T000H11_n115OrdenEst, T000H11_A117OrdenModeloID, T000H11_A119OrdenFch, T000H11_n119OrdenFch,
               T000H11_A106facturaNro, T000H11_n106facturaNro, T000H11_A107representane, T000H11_n107representane, T000H11_A203ordenNroPed, T000H11_n203ordenNroPed, T000H11_A109fchVenta, T000H11_n109fchVenta, T000H11_A110cantDias, T000H11_n110cantDias,
               T000H11_A132OrdenEmpFac, T000H11_n132OrdenEmpFac, T000H11_A133OrdenProceso, T000H11_n133OrdenProceso, T000H11_A161OrdenSubtotal, T000H11_n161OrdenSubtotal, T000H11_A162OrdenValInds, T000H11_n162OrdenValInds, T000H11_A163OrdenValEnrq, T000H11_n163OrdenValEnrq,
               T000H11_A165OrdenValCal, T000H11_n165OrdenValCal, T000H11_A166OrdenValPint, T000H11_n166OrdenValPint, T000H11_A167OrdenValEstr, T000H11_n167OrdenValEstr, T000H11_A168OrdenValOtrs, T000H11_n168OrdenValOtrs, T000H11_A172OrdenfchEnt, T000H11_n172OrdenfchEnt,
               T000H11_A192OrdenPed, T000H11_n192OrdenPed, T000H11_A195OrdenFacNomb, T000H11_n195OrdenFacNomb, T000H11_A210OrdenUltSec, T000H11_n210OrdenUltSec, T000H11_A401OrdenNroDesp, T000H11_n401OrdenNroDesp, T000H11_A1EmpID, T000H11_A5ClienteID,
               T000H11_A26OrdenMarcaID, T000H11_A8VehiculoID, T000H11_A9vendedorID, T000H11_A10protID, T000H11_A17tipOrdID, T000H11_A108urlPdf, T000H11_n108urlPdf, T000H11_A112documento, T000H11_n112documento, T000H11_A152OrdenPdf,
               T000H11_n152OrdenPdf, T000H11_A153OrdenActaPdf, T000H11_n153OrdenActaPdf
               }
               , new Object[] {
               T000H12_A44empdsc, T000H12_n44empdsc
               }
               , new Object[] {
               T000H13_A57ClienteDsc, T000H13_n57ClienteDsc
               }
               , new Object[] {
               T000H14_A6MarcaID
               }
               , new Object[] {
               T000H15_A68VehiculoPlaca, T000H15_n68VehiculoPlaca, T000H15_A69VehiculoChasis, T000H15_n69VehiculoChasis
               }
               , new Object[] {
               T000H16_A72vendedorDsc, T000H16_n72vendedorDsc
               }
               , new Object[] {
               T000H17_A74protDsc, T000H17_n74protDsc
               }
               , new Object[] {
               T000H18_A104tipOrdDsc, T000H18_n104tipOrdDsc
               }
               , new Object[] {
               T000H19_A6MarcaID
               }
               , new Object[] {
               T000H21_A255OrdenObreSuma, T000H21_n255OrdenObreSuma
               }
               , new Object[] {
               T000H23_A24OrdenPeriodo, T000H23_A25OrdenAnio, T000H23_A22OrdenID, T000H23_A116OrdenUser, T000H23_n116OrdenUser, T000H23_A115OrdenEst, T000H23_n115OrdenEst, T000H23_A44empdsc, T000H23_n44empdsc, T000H23_A57ClienteDsc,
               T000H23_n57ClienteDsc, T000H23_A68VehiculoPlaca, T000H23_n68VehiculoPlaca, T000H23_A69VehiculoChasis, T000H23_n69VehiculoChasis, T000H23_A117OrdenModeloID, T000H23_A119OrdenFch, T000H23_n119OrdenFch, T000H23_A104tipOrdDsc, T000H23_n104tipOrdDsc,
               T000H23_A72vendedorDsc, T000H23_n72vendedorDsc, T000H23_A106facturaNro, T000H23_n106facturaNro, T000H23_A107representane, T000H23_n107representane, T000H23_A203ordenNroPed, T000H23_n203ordenNroPed, T000H23_A74protDsc, T000H23_n74protDsc,
               T000H23_A109fchVenta, T000H23_n109fchVenta, T000H23_A110cantDias, T000H23_n110cantDias, T000H23_A132OrdenEmpFac, T000H23_n132OrdenEmpFac, T000H23_A133OrdenProceso, T000H23_n133OrdenProceso, T000H23_A161OrdenSubtotal, T000H23_n161OrdenSubtotal,
               T000H23_A162OrdenValInds, T000H23_n162OrdenValInds, T000H23_A163OrdenValEnrq, T000H23_n163OrdenValEnrq, T000H23_A165OrdenValCal, T000H23_n165OrdenValCal, T000H23_A166OrdenValPint, T000H23_n166OrdenValPint, T000H23_A167OrdenValEstr, T000H23_n167OrdenValEstr,
               T000H23_A168OrdenValOtrs, T000H23_n168OrdenValOtrs, T000H23_A172OrdenfchEnt, T000H23_n172OrdenfchEnt, T000H23_A192OrdenPed, T000H23_n192OrdenPed, T000H23_A195OrdenFacNomb, T000H23_n195OrdenFacNomb, T000H23_A210OrdenUltSec, T000H23_n210OrdenUltSec,
               T000H23_A401OrdenNroDesp, T000H23_n401OrdenNroDesp, T000H23_A1EmpID, T000H23_A5ClienteID, T000H23_A26OrdenMarcaID, T000H23_A8VehiculoID, T000H23_A9vendedorID, T000H23_A10protID, T000H23_A17tipOrdID, T000H23_A255OrdenObreSuma,
               T000H23_n255OrdenObreSuma, T000H23_A108urlPdf, T000H23_n108urlPdf, T000H23_A112documento, T000H23_n112documento, T000H23_A152OrdenPdf, T000H23_n152OrdenPdf, T000H23_A153OrdenActaPdf, T000H23_n153OrdenActaPdf
               }
               , new Object[] {
               T000H24_A44empdsc, T000H24_n44empdsc
               }
               , new Object[] {
               T000H25_A68VehiculoPlaca, T000H25_n68VehiculoPlaca, T000H25_A69VehiculoChasis, T000H25_n69VehiculoChasis
               }
               , new Object[] {
               T000H26_A72vendedorDsc, T000H26_n72vendedorDsc
               }
               , new Object[] {
               T000H27_A74protDsc, T000H27_n74protDsc
               }
               , new Object[] {
               T000H28_A104tipOrdDsc, T000H28_n104tipOrdDsc
               }
               , new Object[] {
               T000H29_A57ClienteDsc, T000H29_n57ClienteDsc
               }
               , new Object[] {
               T000H31_A255OrdenObreSuma, T000H31_n255OrdenObreSuma
               }
               , new Object[] {
               T000H32_A1EmpID, T000H32_A5ClienteID, T000H32_A24OrdenPeriodo, T000H32_A25OrdenAnio, T000H32_A22OrdenID
               }
               , new Object[] {
               T000H33_A24OrdenPeriodo, T000H33_A25OrdenAnio, T000H33_A22OrdenID, T000H33_A1EmpID, T000H33_A5ClienteID
               }
               , new Object[] {
               T000H34_A24OrdenPeriodo, T000H34_A25OrdenAnio, T000H34_A22OrdenID, T000H34_A1EmpID, T000H34_A5ClienteID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H42_A44empdsc, T000H42_n44empdsc
               }
               , new Object[] {
               T000H43_A57ClienteDsc, T000H43_n57ClienteDsc
               }
               , new Object[] {
               T000H45_A255OrdenObreSuma, T000H45_n255OrdenObreSuma
               }
               , new Object[] {
               T000H46_A68VehiculoPlaca, T000H46_n68VehiculoPlaca, T000H46_A69VehiculoChasis, T000H46_n69VehiculoChasis
               }
               , new Object[] {
               T000H47_A104tipOrdDsc, T000H47_n104tipOrdDsc
               }
               , new Object[] {
               T000H48_A72vendedorDsc, T000H48_n72vendedorDsc
               }
               , new Object[] {
               T000H49_A74protDsc, T000H49_n74protDsc
               }
               , new Object[] {
               }
               , new Object[] {
               T000H51_A1EmpID, T000H51_A5ClienteID, T000H51_A24OrdenPeriodo, T000H51_A25OrdenAnio, T000H51_A22OrdenID
               }
               , new Object[] {
               T000H52_A5ClienteID, T000H52_A24OrdenPeriodo, T000H52_A25OrdenAnio, T000H52_A22OrdenID, T000H52_A252OrdenObrID, T000H52_A238ObreID, T000H52_A253OrdenObreManObra, T000H52_n253OrdenObreManObra, T000H52_A254OrdenObreValor, T000H52_n254OrdenObreValor,
               T000H52_A1EmpID
               }
               , new Object[] {
               T000H53_A1EmpID, T000H53_A5ClienteID, T000H53_A24OrdenPeriodo, T000H53_A25OrdenAnio, T000H53_A22OrdenID, T000H53_A252OrdenObrID, T000H53_A238ObreID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H57_A1EmpID, T000H57_A5ClienteID, T000H57_A24OrdenPeriodo, T000H57_A25OrdenAnio, T000H57_A22OrdenID, T000H57_A252OrdenObrID, T000H57_A238ObreID
               }
               , new Object[] {
               T000H58_A5ClienteID, T000H58_A24OrdenPeriodo, T000H58_A25OrdenAnio, T000H58_A22OrdenID, T000H58_A41OrdenSecId, T000H58_A146categDsc, T000H58_n146categDsc, T000H58_A148subCatDsc, T000H58_n148subCatDsc, T000H58_A150subCatPrec,
               T000H58_n150subCatPrec, T000H58_A208OrdenDetCant, T000H58_n208OrdenDetCant, T000H58_A251OrdenDetDetalle, T000H58_n251OrdenDetDetalle, T000H58_A396OrdenDetDesp, T000H58_n396OrdenDetDesp, T000H58_A397OrdenDesp, T000H58_n397OrdenDesp, T000H58_A1EmpID,
               T000H58_A36detTipoProdID, T000H58_A32categID, T000H58_A33subCatID
               }
               , new Object[] {
               T000H59_A146categDsc, T000H59_n146categDsc
               }
               , new Object[] {
               T000H60_A148subCatDsc, T000H60_n148subCatDsc, T000H60_A150subCatPrec, T000H60_n150subCatPrec
               }
               , new Object[] {
               T000H61_A1EmpID, T000H61_A5ClienteID, T000H61_A24OrdenPeriodo, T000H61_A25OrdenAnio, T000H61_A22OrdenID, T000H61_A41OrdenSecId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H65_A146categDsc, T000H65_n146categDsc
               }
               , new Object[] {
               T000H66_A148subCatDsc, T000H66_n148subCatDsc, T000H66_A150subCatPrec, T000H66_n150subCatPrec
               }
               , new Object[] {
               T000H67_A1EmpID, T000H67_A5ClienteID, T000H67_A24OrdenPeriodo, T000H67_A25OrdenAnio, T000H67_A22OrdenID, T000H67_A41OrdenSecId
               }
               , new Object[] {
               T000H68_A3UsuCod, T000H68_A398UsuAlias, T000H68_n398UsuAlias
               }
               , new Object[] {
               T000H69_A20ProcID, T000H69_A129ProcAbre, T000H69_n129ProcAbre, T000H69_A128ProcDsc, T000H69_n128ProcDsc
               }
               , new Object[] {
               T000H70_A1EmpID, T000H70_A44empdsc, T000H70_n44empdsc, T000H70_A45EmpEst, T000H70_n45EmpEst
               }
               , new Object[] {
               T000H71_A1EmpID, T000H71_A6MarcaID, T000H71_A62MarcaDsc, T000H71_n62MarcaDsc
               }
               , new Object[] {
               T000H72_A1EmpID, T000H72_A6MarcaID, T000H72_A7ModeloID, T000H72_A64ModeloDsc, T000H72_n64ModeloDsc
               }
               , new Object[] {
               T000H73_A1EmpID, T000H73_A5ClienteID, T000H73_A57ClienteDsc, T000H73_n57ClienteDsc
               }
               , new Object[] {
               T000H74_A1EmpID, T000H74_A9vendedorID, T000H74_A72vendedorDsc, T000H74_n72vendedorDsc, T000H74_A73vendedorEst, T000H74_n73vendedorEst
               }
               , new Object[] {
               T000H75_A1EmpID, T000H75_A17tipOrdID, T000H75_A104tipOrdDsc, T000H75_n104tipOrdDsc
               }
               , new Object[] {
               T000H76_A1EmpID, T000H76_A10protID, T000H76_A74protDsc, T000H76_n74protDsc
               }
               , new Object[] {
               T000H77_A239ObreCedula, T000H77_A238ObreID, T000H77_A244ObreNombre
               }
               , new Object[] {
               T000H78_A1EmpID, T000H78_A31tipoProdID, T000H78_A144tipoProdDsc, T000H78_n144tipoProdDsc
               }
               , new Object[] {
               T000H79_A1EmpID, T000H79_A32categID, T000H79_A146categDsc, T000H79_n146categDsc, T000H79_A31tipoProdID
               }
               , new Object[] {
               T000H80_A6MarcaID
               }
               , new Object[] {
               T000H81_A6MarcaID
               }
               , new Object[] {
               T000H82_A31tipoProdID
               }
               , new Object[] {
               T000H83_A146categDsc, T000H83_n146categDsc
               }
               , new Object[] {
               T000H84_A148subCatDsc, T000H84_n148subCatDsc, T000H84_A150subCatPrec, T000H84_n150subCatPrec
               }
            }
         );
         AV46Pgmname = "OrdenProduccion";
         AV43ordenDesp = 0;
         iV43ordenDesp = 0;
         Z132OrdenEmpFac = 1;
         n132OrdenEmpFac = false;
         A132OrdenEmpFac = 1;
         n132OrdenEmpFac = false;
         i132OrdenEmpFac = 1;
         n132OrdenEmpFac = false;
         AV11facEmp = 1;
         iV11facEmp = 1;
         Z133OrdenProceso = "PEND";
         n133OrdenProceso = false;
         A133OrdenProceso = "PEND";
         n133OrdenProceso = false;
         i133OrdenProceso = "PEND";
         n133OrdenProceso = false;
         Z119OrdenFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n119OrdenFch = false;
         A119OrdenFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n119OrdenFch = false;
         i119OrdenFch = DateTimeUtil.ResetTime(DateTimeUtil.ServerNow( context, pr_default));
         n119OrdenFch = false;
      }

      private short nIsMod_17 ;
      private short wcpOAV10EmpID ;
      private short wcpOAV7ageID ;
      private short wcpOAV9ClienteID ;
      private short wcpOAV27OrdenPeriodo ;
      private short wcpOAV25OrdenAnio ;
      private short wcpOAV26OrdenID ;
      private short Z1EmpID ;
      private short Z5ClienteID ;
      private short Z24OrdenPeriodo ;
      private short Z25OrdenAnio ;
      private short Z22OrdenID ;
      private short Z117OrdenModeloID ;
      private short Z110cantDias ;
      private short Z132OrdenEmpFac ;
      private short Z210OrdenUltSec ;
      private short Z26OrdenMarcaID ;
      private short Z8VehiculoID ;
      private short Z9vendedorID ;
      private short Z10protID ;
      private short Z17tipOrdID ;
      private short O210OrdenUltSec ;
      private short nRC_GXsfl_261 ;
      private short nGXsfl_261_idx=1 ;
      private short nRC_GXsfl_216 ;
      private short nGXsfl_216_idx=1 ;
      private short N8VehiculoID ;
      private short N26OrdenMarcaID ;
      private short N17tipOrdID ;
      private short N9vendedorID ;
      private short N10protID ;
      private short Z252OrdenObrID ;
      private short Z238ObreID ;
      private short nRcdDeleted_52 ;
      private short nRcdExists_52 ;
      private short nIsMod_52 ;
      private short Z41OrdenSecId ;
      private short Z396OrdenDetDesp ;
      private short Z397OrdenDesp ;
      private short Z36detTipoProdID ;
      private short Z32categID ;
      private short Z33subCatID ;
      private short nRcdDeleted_17 ;
      private short nRcdExists_17 ;
      private short GxWebError ;
      private short AV10EmpID ;
      private short AV22MarcaID ;
      private short A1EmpID ;
      private short A36detTipoProdID ;
      private short AV26OrdenID ;
      private short AV25OrdenAnio ;
      private short A26OrdenMarcaID ;
      private short A8VehiculoID ;
      private short A9vendedorID ;
      private short A10protID ;
      private short A17tipOrdID ;
      private short A5ClienteID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A22OrdenID ;
      private short A32categID ;
      private short A33subCatID ;
      private short A210OrdenUltSec ;
      private short Gx_BScreen ;
      private short AV7ageID ;
      private short AV9ClienteID ;
      private short AV27OrdenPeriodo ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short nDynComponent ;
      private short A132OrdenEmpFac ;
      private short A117OrdenModeloID ;
      private short AV11facEmp ;
      private short A110cantDias ;
      private short AV34valueNro ;
      private short subGriditemsop_Backcolorstyle ;
      private short subGriditemsop_Sortable ;
      private short A41OrdenSecId ;
      private short A396OrdenDetDesp ;
      private short A397OrdenDesp ;
      private short subGriditemsop_Allowselection ;
      private short subGriditemsop_Allowhovering ;
      private short subGriditemsop_Allowcollapsing ;
      private short subGriditemsop_Collapsed ;
      private short nBlankRcdCount17 ;
      private short RcdFound17 ;
      private short B210OrdenUltSec ;
      private short nBlankRcdUsr17 ;
      private short subGrid1_Backcolorstyle ;
      private short A252OrdenObrID ;
      private short A238ObreID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount52 ;
      private short RcdFound52 ;
      private short nBlankRcdUsr52 ;
      private short AV43ordenDesp ;
      private short AV19Insert_VehiculoID ;
      private short AV15Insert_OrdenMarcaID ;
      private short AV18Insert_tipOrdID ;
      private short AV20Insert_vendedorID ;
      private short AV17Insert_protID ;
      private short A6MarcaID ;
      private short A31tipoProdID ;
      private short RcdFound16 ;
      private short s210OrdenUltSec ;
      private short GX_JID ;
      private short subGrid1_Backstyle ;
      private short subGriditemsop_Backstyle ;
      private short iV11facEmp ;
      private short i132OrdenEmpFac ;
      private short iV43ordenDesp ;
      private short i210OrdenUltSec ;
      private short GXt_int1 ;
      private short wbTemp ;
      private int Z106facturaNro ;
      private int Z203ordenNroPed ;
      private int Z192OrdenPed ;
      private int Z401OrdenNroDesp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtOrdenFch_Enabled ;
      private int edtOrdenfchEnt_Visible ;
      private int edtOrdenfchEnt_Enabled ;
      private int edtOrdenAnio_Enabled ;
      private int edtEmpID_Enabled ;
      private int imgprompt_1_Visible ;
      private int edtempdsc_Enabled ;
      private int divTbempfac_Visible ;
      private int imgprompt_26_Visible ;
      private int imgprompt_5_Visible ;
      private int edtOrdenFacNomb_Visible ;
      private int edtOrdenFacNomb_Enabled ;
      private int imgprompt_9_Visible ;
      private int edtOrdenID_Enabled ;
      private int imgprompt_17_Visible ;
      private int imgprompt_10_Visible ;
      private int A106facturaNro ;
      private int edtfacturaNro_Enabled ;
      private int edtrepresentane_Enabled ;
      private int edtVehiculoID_Enabled ;
      private int imgprompt_8_Visible ;
      private int edtVehiculoPlaca_Enabled ;
      private int edtVehiculoChasis_Enabled ;
      private int edtOrdenPdf_Enabled ;
      private int edtfchVenta_Enabled ;
      private int edtcantDias_Enabled ;
      private int edtOrdenActaPdf_Enabled ;
      private int edtOrdenSubtotal_Enabled ;
      private int A401OrdenNroDesp ;
      private int edtOrdenNroDesp_Enabled ;
      private int edtavErrormesjtool_Enabled ;
      private int bttButton3_Visible ;
      private int bttButton1_Visible ;
      private int edtOrdenValInds_Enabled ;
      private int edtOrdenValEnrq_Enabled ;
      private int edtOrdenValCal_Enabled ;
      private int edtOrdenValMatPri_Enabled ;
      private int edtOrdenObreSuma_Enabled ;
      private int edtOrdenTotGast_Enabled ;
      private int edtOrdenValRenta_Enabled ;
      private int edtavMarcaid_Enabled ;
      private int edtavMarcaid_Visible ;
      private int edtavEmpid_Enabled ;
      private int edtavEmpid_Visible ;
      private int edtavValuenro_Visible ;
      private int edtavValuenro_Enabled ;
      private int bttBtnenter2_Visible ;
      private int bttButton2_Visible ;
      private int edtOrdenSecId_Enabled ;
      private int edtcategDsc_Enabled ;
      private int edtsubCatID_Enabled ;
      private int edtsubCatDsc_Enabled ;
      private int edtsubCatPrec_Enabled ;
      private int edtOrdenDetCant_Enabled ;
      private int edtOrdenDetVal_Enabled ;
      private int edtOrdenDetDetalle_Enabled ;
      private int edtOrdenDesp_Enabled ;
      private int subGriditemsop_Selectedindex ;
      private int subGriditemsop_Selectioncolor ;
      private int subGriditemsop_Hoveringcolor ;
      private int fRowAdded ;
      private int edtOrdenObrID_Enabled ;
      private int edtOrdenObreManObra_Enabled ;
      private int edtOrdenObreValor_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int A203ordenNroPed ;
      private int A192OrdenPed ;
      private int Tabcosteo_Activepage ;
      private int Tabcosteo_Pagecount ;
      private int AV47GXV1 ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGriditemsop_Backcolor ;
      private int subGriditemsop_Allbackcolor ;
      private int imgprompt_36_Visible ;
      private int imgprompt_32_Visible ;
      private int imgprompt_33_Visible ;
      private int defdynObreID_Enabled ;
      private int defedtOrdenObrID_Enabled ;
      private int defedtOrdenDesp_Enabled ;
      private int defedtcategDsc_Enabled ;
      private int defedtOrdenSecId_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRIDITEMSOP_nFirstRecordOnPage ;
      private decimal Z161OrdenSubtotal ;
      private decimal Z162OrdenValInds ;
      private decimal Z163OrdenValEnrq ;
      private decimal Z165OrdenValCal ;
      private decimal Z166OrdenValPint ;
      private decimal Z167OrdenValEstr ;
      private decimal Z168OrdenValOtrs ;
      private decimal Z254OrdenObreValor ;
      private decimal Z208OrdenDetCant ;
      private decimal A161OrdenSubtotal ;
      private decimal A162OrdenValInds ;
      private decimal A163OrdenValEnrq ;
      private decimal A165OrdenValCal ;
      private decimal A164OrdenValMatPri ;
      private decimal A255OrdenObreSuma ;
      private decimal A170OrdenTotGast ;
      private decimal A171OrdenValRenta ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private decimal A254OrdenObreValor ;
      private decimal A166OrdenValPint ;
      private decimal A167OrdenValEstr ;
      private decimal A168OrdenValOtrs ;
      private decimal A169OrdenValManObr ;
      private decimal Z255OrdenObreSuma ;
      private decimal Z150subCatPrec ;
      private String sPrefix ;
      private String sGXsfl_216_idx="0001" ;
      private String wcpOGx_mode ;
      private String wcpOAV33usuCod ;
      private String Z116OrdenUser ;
      private String Z115OrdenEst ;
      private String Z107representane ;
      private String Z195OrdenFacNomb ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String chkOrdenDetDesp_Internalname ;
      private String sGXsfl_261_idx="0001" ;
      private String Gx_mode ;
      private String AV33usuCod ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtOrdenFch_Internalname ;
      private String dynavUsucod_Internalname ;
      private String cmbOrdenPeriodo_Internalname ;
      private String dynOrdenProceso_Internalname ;
      private String dynOrdenEmpFac_Internalname ;
      private String dynOrdenMarcaID_Internalname ;
      private String dynOrdenModeloID_Internalname ;
      private String dynClienteID_Internalname ;
      private String dynvendedorID_Internalname ;
      private String dyntipOrdID_Internalname ;
      private String dynprotID_Internalname ;
      private String A115OrdenEst ;
      private String cmbOrdenEst_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
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
      private String edtOrdenFch_Jsonclick ;
      private String dynavUsucod_Jsonclick ;
      private String edtOrdenfchEnt_Internalname ;
      private String edtOrdenfchEnt_Jsonclick ;
      private String divTable1_Internalname ;
      private String divSection3_Internalname ;
      private String edtOrdenAnio_Internalname ;
      private String edtOrdenAnio_Jsonclick ;
      private String divSection2_Internalname ;
      private String cmbOrdenPeriodo_Jsonclick ;
      private String divSection1_Internalname ;
      private String dynOrdenProceso_Jsonclick ;
      private String edtEmpID_Internalname ;
      private String edtEmpID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_1_Internalname ;
      private String imgprompt_1_Link ;
      private String edtempdsc_Internalname ;
      private String edtempdsc_Jsonclick ;
      private String chkavFacemp_Internalname ;
      private String divTbempfac_Internalname ;
      private String dynOrdenEmpFac_Jsonclick ;
      private String dynOrdenMarcaID_Jsonclick ;
      private String imgprompt_26_Internalname ;
      private String imgprompt_26_Link ;
      private String dynOrdenModeloID_Jsonclick ;
      private String dynClienteID_Jsonclick ;
      private String imgprompt_5_Internalname ;
      private String imgprompt_5_Link ;
      private String divTbnomfac_Internalname ;
      private String edtOrdenFacNomb_Internalname ;
      private String A195OrdenFacNomb ;
      private String edtOrdenFacNomb_Jsonclick ;
      private String dynvendedorID_Jsonclick ;
      private String imgprompt_9_Internalname ;
      private String imgprompt_9_Link ;
      private String edtOrdenID_Internalname ;
      private String edtOrdenID_Jsonclick ;
      private String dyntipOrdID_Jsonclick ;
      private String imgprompt_17_Internalname ;
      private String imgprompt_17_Link ;
      private String dynprotID_Jsonclick ;
      private String imgprompt_10_Internalname ;
      private String imgprompt_10_Link ;
      private String edtfacturaNro_Internalname ;
      private String edtfacturaNro_Jsonclick ;
      private String edtrepresentane_Internalname ;
      private String A107representane ;
      private String edtrepresentane_Jsonclick ;
      private String edtVehiculoID_Internalname ;
      private String edtVehiculoID_Jsonclick ;
      private String imgprompt_8_Internalname ;
      private String imgprompt_8_Link ;
      private String edtVehiculoPlaca_Internalname ;
      private String edtVehiculoPlaca_Jsonclick ;
      private String edtVehiculoChasis_Internalname ;
      private String edtVehiculoChasis_Jsonclick ;
      private String edtOrdenPdf_Internalname ;
      private String edtOrdenPdf_Filetype ;
      private String edtOrdenPdf_Contenttype ;
      private String edtOrdenPdf_Parameters ;
      private String edtOrdenPdf_Jsonclick ;
      private String edtfchVenta_Internalname ;
      private String edtfchVenta_Jsonclick ;
      private String edtcantDias_Internalname ;
      private String edtcantDias_Jsonclick ;
      private String edtOrdenActaPdf_Internalname ;
      private String edtOrdenActaPdf_Filetype ;
      private String edtOrdenActaPdf_Contenttype ;
      private String edtOrdenActaPdf_Parameters ;
      private String edtOrdenActaPdf_Jsonclick ;
      private String edtOrdenSubtotal_Internalname ;
      private String edtOrdenSubtotal_Jsonclick ;
      private String cmbOrdenEst_Jsonclick ;
      private String edtOrdenNroDesp_Internalname ;
      private String edtOrdenNroDesp_Jsonclick ;
      private String lblItems_title_Internalname ;
      private String lblItems_title_Jsonclick ;
      private String divTabpage1table3_Internalname ;
      private String edtavErrormesjtool_Internalname ;
      private String edtavErrormesjtool_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblCosteomatprim_title_Internalname ;
      private String lblCosteomatprim_title_Jsonclick ;
      private String divTabpage1table_Internalname ;
      private String edtOrdenValInds_Internalname ;
      private String edtOrdenValInds_Jsonclick ;
      private String edtOrdenValEnrq_Internalname ;
      private String edtOrdenValEnrq_Jsonclick ;
      private String edtOrdenValCal_Internalname ;
      private String edtOrdenValCal_Jsonclick ;
      private String edtOrdenValMatPri_Internalname ;
      private String edtOrdenValMatPri_Jsonclick ;
      private String lblManoobra_title_Internalname ;
      private String lblManoobra_title_Jsonclick ;
      private String divTabpage1table1_Internalname ;
      private String edtOrdenObreSuma_Internalname ;
      private String edtOrdenObreSuma_Jsonclick ;
      private String lblTotalrenta_title_Internalname ;
      private String lblTotalrenta_title_Jsonclick ;
      private String divTabpage1table2_Internalname ;
      private String edtOrdenTotGast_Internalname ;
      private String edtOrdenTotGast_Jsonclick ;
      private String edtOrdenValRenta_Internalname ;
      private String edtOrdenValRenta_Jsonclick ;
      private String edtavMarcaid_Internalname ;
      private String edtavMarcaid_Jsonclick ;
      private String edtavEmpid_Internalname ;
      private String edtavEmpid_Jsonclick ;
      private String edtavValuenro_Internalname ;
      private String edtavValuenro_Jsonclick ;
      private String bttBtnenter2_Internalname ;
      private String bttBtnenter2_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String subGriditemsop_Header ;
      private String A146categDsc ;
      private String A148subCatDsc ;
      private String sMode17 ;
      private String edtOrdenSecId_Internalname ;
      private String dyndetTipoProdID_Internalname ;
      private String dyncategID_Internalname ;
      private String edtcategDsc_Internalname ;
      private String edtsubCatID_Internalname ;
      private String edtsubCatDsc_Internalname ;
      private String edtsubCatPrec_Internalname ;
      private String edtOrdenDetCant_Internalname ;
      private String edtOrdenDetVal_Internalname ;
      private String edtOrdenDetDetalle_Internalname ;
      private String edtOrdenDesp_Internalname ;
      private String sStyleString ;
      private String subGrid1_Header ;
      private String sMode52 ;
      private String edtOrdenObrID_Internalname ;
      private String dynObreID_Internalname ;
      private String edtOrdenObreManObra_Internalname ;
      private String edtOrdenObreValor_Internalname ;
      private String A116OrdenUser ;
      private String A57ClienteDsc ;
      private String A72vendedorDsc ;
      private String A74protDsc ;
      private String A104tipOrdDsc ;
      private String AV46Pgmname ;
      private String Tabcosteo_Objectcall ;
      private String Tabcosteo_Class ;
      private String Tabcosteo_Activepagecontrolname ;
      private String edtOrdenPdf_Filename ;
      private String edtOrdenActaPdf_Filename ;
      private String GXCCtlgxBlob ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode16 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String AV28rolUser ;
      private String Tabcosteo_Internalname ;
      private String GXt_char2 ;
      private String Z57ClienteDsc ;
      private String Z104tipOrdDsc ;
      private String Z72vendedorDsc ;
      private String Z74protDsc ;
      private String Z146categDsc ;
      private String Z148subCatDsc ;
      private String sGXsfl_261_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String ROClassString ;
      private String edtOrdenObrID_Jsonclick ;
      private String dynObreID_Jsonclick ;
      private String edtOrdenObreManObra_Jsonclick ;
      private String edtOrdenObreValor_Jsonclick ;
      private String imgprompt_36_Internalname ;
      private String imgprompt_32_Internalname ;
      private String imgprompt_33_Internalname ;
      private String sGXsfl_216_fel_idx="0001" ;
      private String subGriditemsop_Class ;
      private String subGriditemsop_Linesclass ;
      private String imgprompt_33_Link ;
      private String imgprompt_32_Link ;
      private String imgprompt_36_Link ;
      private String edtOrdenSecId_Jsonclick ;
      private String dyndetTipoProdID_Jsonclick ;
      private String dyncategID_Jsonclick ;
      private String edtcategDsc_Jsonclick ;
      private String edtsubCatID_Jsonclick ;
      private String edtsubCatDsc_Jsonclick ;
      private String edtsubCatPrec_Jsonclick ;
      private String edtOrdenDetCant_Jsonclick ;
      private String edtOrdenDetVal_Jsonclick ;
      private String edtOrdenDetDetalle_Jsonclick ;
      private String edtOrdenDesp_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String i115OrdenEst ;
      private String i116OrdenUser ;
      private String subGriditemsop_Internalname ;
      private String subGrid1_Internalname ;
      private String gxwrpcisep ;
      private DateTime Z119OrdenFch ;
      private DateTime Z109fchVenta ;
      private DateTime Z172OrdenfchEnt ;
      private DateTime A119OrdenFch ;
      private DateTime A172OrdenfchEnt ;
      private DateTime A109fchVenta ;
      private DateTime AV12fechaCtrol ;
      private DateTime i119OrdenFch ;
      private bool entryPointCalled ;
      private bool bGXsfl_216_Refreshing=false ;
      private bool n210OrdenUltSec ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n133OrdenProceso ;
      private bool n132OrdenEmpFac ;
      private bool n115OrdenEst ;
      private bool n152OrdenPdf ;
      private bool n153OrdenActaPdf ;
      private bool bGXsfl_261_Refreshing=false ;
      private bool n119OrdenFch ;
      private bool n172OrdenfchEnt ;
      private bool n44empdsc ;
      private bool n195OrdenFacNomb ;
      private bool n106facturaNro ;
      private bool n107representane ;
      private bool n68VehiculoPlaca ;
      private bool n69VehiculoChasis ;
      private bool n109fchVenta ;
      private bool n110cantDias ;
      private bool n161OrdenSubtotal ;
      private bool n401OrdenNroDesp ;
      private bool n162OrdenValInds ;
      private bool n163OrdenValEnrq ;
      private bool n165OrdenValCal ;
      private bool n255OrdenObreSuma ;
      private bool n116OrdenUser ;
      private bool n203ordenNroPed ;
      private bool n166OrdenValPint ;
      private bool n167OrdenValEstr ;
      private bool n168OrdenValOtrs ;
      private bool n192OrdenPed ;
      private bool n108urlPdf ;
      private bool n112documento ;
      private bool n57ClienteDsc ;
      private bool n72vendedorDsc ;
      private bool n74protDsc ;
      private bool n104tipOrdDsc ;
      private bool n242ObrePrApellido ;
      private bool n243ObreSegApellido ;
      private bool n240ObrePrNombre ;
      private bool n241ObreSegNombre ;
      private bool Tabcosteo_Enabled ;
      private bool Tabcosteo_Historymanagement ;
      private bool Tabcosteo_Visible ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool n253OrdenObreManObra ;
      private bool n254OrdenObreValor ;
      private bool n146categDsc ;
      private bool n148subCatDsc ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private bool n251OrdenDetDetalle ;
      private bool n396OrdenDetDesp ;
      private bool n397OrdenDesp ;
      private bool gxdyncontrolsrefreshing ;
      private String Z133OrdenProceso ;
      private String Z253OrdenObreManObra ;
      private String Z251OrdenDetDetalle ;
      private String A133OrdenProceso ;
      private String A44empdsc ;
      private String A68VehiculoPlaca ;
      private String A69VehiculoChasis ;
      private String AV40errorMesjTool ;
      private String A251OrdenDetDetalle ;
      private String A253OrdenObreManObra ;
      private String A242ObrePrApellido ;
      private String A243ObreSegApellido ;
      private String A240ObrePrNombre ;
      private String A241ObreSegNombre ;
      private String A244ObreNombre ;
      private String AV36archivo ;
      private String AV37ErrorMessage ;
      private String Z44empdsc ;
      private String Z68VehiculoPlaca ;
      private String Z69VehiculoChasis ;
      private String i133OrdenProceso ;
      private String A152OrdenPdf ;
      private String A153OrdenActaPdf ;
      private String A108urlPdf ;
      private String A112documento ;
      private String Z108urlPdf ;
      private String Z112documento ;
      private String Z152OrdenPdf ;
      private String Z153OrdenActaPdf ;
      private IGxSession AV35WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private GXWebGrid GriditemsopContainer ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebRow GriditemsopRow ;
      private GXWebColumn GriditemsopColumn ;
      private GXWebColumn Grid1Column ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavUsucod ;
      private GXCombobox cmbOrdenPeriodo ;
      private GXCombobox dynOrdenProceso ;
      private GXCheckbox chkavFacemp ;
      private GXCombobox dynOrdenEmpFac ;
      private GXCombobox dynOrdenMarcaID ;
      private GXCombobox dynOrdenModeloID ;
      private GXCombobox dynClienteID ;
      private GXCombobox dynvendedorID ;
      private GXCombobox dyntipOrdID ;
      private GXCombobox dynprotID ;
      private GXCombobox cmbOrdenEst ;
      private GXCombobox dyndetTipoProdID ;
      private GXCombobox dyncategID ;
      private GXCheckbox chkOrdenDetDesp ;
      private GXCombobox dynObreID ;
      private IDataStoreProvider pr_default ;
      private String[] T000H12_A44empdsc ;
      private bool[] T000H12_n44empdsc ;
      private String[] T000H13_A57ClienteDsc ;
      private bool[] T000H13_n57ClienteDsc ;
      private String[] T000H16_A72vendedorDsc ;
      private bool[] T000H16_n72vendedorDsc ;
      private String[] T000H17_A74protDsc ;
      private bool[] T000H17_n74protDsc ;
      private String[] T000H18_A104tipOrdDsc ;
      private bool[] T000H18_n104tipOrdDsc ;
      private String[] T000H15_A68VehiculoPlaca ;
      private bool[] T000H15_n68VehiculoPlaca ;
      private String[] T000H15_A69VehiculoChasis ;
      private bool[] T000H15_n69VehiculoChasis ;
      private decimal[] T000H21_A255OrdenObreSuma ;
      private bool[] T000H21_n255OrdenObreSuma ;
      private short[] T000H23_A24OrdenPeriodo ;
      private short[] T000H23_A25OrdenAnio ;
      private short[] T000H23_A22OrdenID ;
      private String[] T000H23_A116OrdenUser ;
      private bool[] T000H23_n116OrdenUser ;
      private String[] T000H23_A115OrdenEst ;
      private bool[] T000H23_n115OrdenEst ;
      private String[] T000H23_A44empdsc ;
      private bool[] T000H23_n44empdsc ;
      private String[] T000H23_A57ClienteDsc ;
      private bool[] T000H23_n57ClienteDsc ;
      private String[] T000H23_A68VehiculoPlaca ;
      private bool[] T000H23_n68VehiculoPlaca ;
      private String[] T000H23_A69VehiculoChasis ;
      private bool[] T000H23_n69VehiculoChasis ;
      private short[] T000H23_A117OrdenModeloID ;
      private DateTime[] T000H23_A119OrdenFch ;
      private bool[] T000H23_n119OrdenFch ;
      private String[] T000H23_A104tipOrdDsc ;
      private bool[] T000H23_n104tipOrdDsc ;
      private String[] T000H23_A72vendedorDsc ;
      private bool[] T000H23_n72vendedorDsc ;
      private int[] T000H23_A106facturaNro ;
      private bool[] T000H23_n106facturaNro ;
      private String[] T000H23_A107representane ;
      private bool[] T000H23_n107representane ;
      private int[] T000H23_A203ordenNroPed ;
      private bool[] T000H23_n203ordenNroPed ;
      private String[] T000H23_A74protDsc ;
      private bool[] T000H23_n74protDsc ;
      private DateTime[] T000H23_A109fchVenta ;
      private bool[] T000H23_n109fchVenta ;
      private short[] T000H23_A110cantDias ;
      private bool[] T000H23_n110cantDias ;
      private short[] T000H23_A132OrdenEmpFac ;
      private bool[] T000H23_n132OrdenEmpFac ;
      private String[] T000H23_A133OrdenProceso ;
      private bool[] T000H23_n133OrdenProceso ;
      private decimal[] T000H23_A161OrdenSubtotal ;
      private bool[] T000H23_n161OrdenSubtotal ;
      private decimal[] T000H23_A162OrdenValInds ;
      private bool[] T000H23_n162OrdenValInds ;
      private decimal[] T000H23_A163OrdenValEnrq ;
      private bool[] T000H23_n163OrdenValEnrq ;
      private decimal[] T000H23_A165OrdenValCal ;
      private bool[] T000H23_n165OrdenValCal ;
      private decimal[] T000H23_A166OrdenValPint ;
      private bool[] T000H23_n166OrdenValPint ;
      private decimal[] T000H23_A167OrdenValEstr ;
      private bool[] T000H23_n167OrdenValEstr ;
      private decimal[] T000H23_A168OrdenValOtrs ;
      private bool[] T000H23_n168OrdenValOtrs ;
      private DateTime[] T000H23_A172OrdenfchEnt ;
      private bool[] T000H23_n172OrdenfchEnt ;
      private int[] T000H23_A192OrdenPed ;
      private bool[] T000H23_n192OrdenPed ;
      private String[] T000H23_A195OrdenFacNomb ;
      private bool[] T000H23_n195OrdenFacNomb ;
      private short[] T000H23_A210OrdenUltSec ;
      private bool[] T000H23_n210OrdenUltSec ;
      private int[] T000H23_A401OrdenNroDesp ;
      private bool[] T000H23_n401OrdenNroDesp ;
      private short[] T000H23_A1EmpID ;
      private short[] T000H23_A5ClienteID ;
      private short[] T000H23_A26OrdenMarcaID ;
      private short[] T000H23_A8VehiculoID ;
      private short[] T000H23_A9vendedorID ;
      private short[] T000H23_A10protID ;
      private short[] T000H23_A17tipOrdID ;
      private decimal[] T000H23_A255OrdenObreSuma ;
      private bool[] T000H23_n255OrdenObreSuma ;
      private String[] T000H23_A108urlPdf ;
      private bool[] T000H23_n108urlPdf ;
      private String[] T000H23_A112documento ;
      private bool[] T000H23_n112documento ;
      private String[] T000H23_A152OrdenPdf ;
      private bool[] T000H23_n152OrdenPdf ;
      private String[] T000H23_A153OrdenActaPdf ;
      private bool[] T000H23_n153OrdenActaPdf ;
      private short[] T000H14_A6MarcaID ;
      private String[] T000H24_A44empdsc ;
      private bool[] T000H24_n44empdsc ;
      private String[] T000H25_A68VehiculoPlaca ;
      private bool[] T000H25_n68VehiculoPlaca ;
      private String[] T000H25_A69VehiculoChasis ;
      private bool[] T000H25_n69VehiculoChasis ;
      private String[] T000H26_A72vendedorDsc ;
      private bool[] T000H26_n72vendedorDsc ;
      private String[] T000H27_A74protDsc ;
      private bool[] T000H27_n74protDsc ;
      private String[] T000H28_A104tipOrdDsc ;
      private bool[] T000H28_n104tipOrdDsc ;
      private String[] T000H29_A57ClienteDsc ;
      private bool[] T000H29_n57ClienteDsc ;
      private decimal[] T000H31_A255OrdenObreSuma ;
      private bool[] T000H31_n255OrdenObreSuma ;
      private short[] T000H32_A1EmpID ;
      private short[] T000H32_A5ClienteID ;
      private short[] T000H32_A24OrdenPeriodo ;
      private short[] T000H32_A25OrdenAnio ;
      private short[] T000H32_A22OrdenID ;
      private short[] T000H11_A24OrdenPeriodo ;
      private short[] T000H11_A25OrdenAnio ;
      private short[] T000H11_A22OrdenID ;
      private String[] T000H11_A116OrdenUser ;
      private bool[] T000H11_n116OrdenUser ;
      private String[] T000H11_A115OrdenEst ;
      private bool[] T000H11_n115OrdenEst ;
      private short[] T000H11_A117OrdenModeloID ;
      private DateTime[] T000H11_A119OrdenFch ;
      private bool[] T000H11_n119OrdenFch ;
      private int[] T000H11_A106facturaNro ;
      private bool[] T000H11_n106facturaNro ;
      private String[] T000H11_A107representane ;
      private bool[] T000H11_n107representane ;
      private int[] T000H11_A203ordenNroPed ;
      private bool[] T000H11_n203ordenNroPed ;
      private DateTime[] T000H11_A109fchVenta ;
      private bool[] T000H11_n109fchVenta ;
      private short[] T000H11_A110cantDias ;
      private bool[] T000H11_n110cantDias ;
      private short[] T000H11_A132OrdenEmpFac ;
      private bool[] T000H11_n132OrdenEmpFac ;
      private String[] T000H11_A133OrdenProceso ;
      private bool[] T000H11_n133OrdenProceso ;
      private decimal[] T000H11_A161OrdenSubtotal ;
      private bool[] T000H11_n161OrdenSubtotal ;
      private decimal[] T000H11_A162OrdenValInds ;
      private bool[] T000H11_n162OrdenValInds ;
      private decimal[] T000H11_A163OrdenValEnrq ;
      private bool[] T000H11_n163OrdenValEnrq ;
      private decimal[] T000H11_A165OrdenValCal ;
      private bool[] T000H11_n165OrdenValCal ;
      private decimal[] T000H11_A166OrdenValPint ;
      private bool[] T000H11_n166OrdenValPint ;
      private decimal[] T000H11_A167OrdenValEstr ;
      private bool[] T000H11_n167OrdenValEstr ;
      private decimal[] T000H11_A168OrdenValOtrs ;
      private bool[] T000H11_n168OrdenValOtrs ;
      private DateTime[] T000H11_A172OrdenfchEnt ;
      private bool[] T000H11_n172OrdenfchEnt ;
      private int[] T000H11_A192OrdenPed ;
      private bool[] T000H11_n192OrdenPed ;
      private String[] T000H11_A195OrdenFacNomb ;
      private bool[] T000H11_n195OrdenFacNomb ;
      private short[] T000H11_A210OrdenUltSec ;
      private bool[] T000H11_n210OrdenUltSec ;
      private int[] T000H11_A401OrdenNroDesp ;
      private bool[] T000H11_n401OrdenNroDesp ;
      private short[] T000H11_A1EmpID ;
      private short[] T000H11_A5ClienteID ;
      private short[] T000H11_A26OrdenMarcaID ;
      private short[] T000H11_A8VehiculoID ;
      private short[] T000H11_A9vendedorID ;
      private short[] T000H11_A10protID ;
      private short[] T000H11_A17tipOrdID ;
      private String[] T000H11_A108urlPdf ;
      private bool[] T000H11_n108urlPdf ;
      private String[] T000H11_A112documento ;
      private bool[] T000H11_n112documento ;
      private String[] T000H11_A152OrdenPdf ;
      private bool[] T000H11_n152OrdenPdf ;
      private String[] T000H11_A153OrdenActaPdf ;
      private bool[] T000H11_n153OrdenActaPdf ;
      private short[] T000H33_A24OrdenPeriodo ;
      private short[] T000H33_A25OrdenAnio ;
      private short[] T000H33_A22OrdenID ;
      private short[] T000H33_A1EmpID ;
      private short[] T000H33_A5ClienteID ;
      private short[] T000H34_A24OrdenPeriodo ;
      private short[] T000H34_A25OrdenAnio ;
      private short[] T000H34_A22OrdenID ;
      private short[] T000H34_A1EmpID ;
      private short[] T000H34_A5ClienteID ;
      private short[] T000H10_A24OrdenPeriodo ;
      private short[] T000H10_A25OrdenAnio ;
      private short[] T000H10_A22OrdenID ;
      private String[] T000H10_A116OrdenUser ;
      private bool[] T000H10_n116OrdenUser ;
      private String[] T000H10_A115OrdenEst ;
      private bool[] T000H10_n115OrdenEst ;
      private short[] T000H10_A117OrdenModeloID ;
      private DateTime[] T000H10_A119OrdenFch ;
      private bool[] T000H10_n119OrdenFch ;
      private int[] T000H10_A106facturaNro ;
      private bool[] T000H10_n106facturaNro ;
      private String[] T000H10_A107representane ;
      private bool[] T000H10_n107representane ;
      private int[] T000H10_A203ordenNroPed ;
      private bool[] T000H10_n203ordenNroPed ;
      private DateTime[] T000H10_A109fchVenta ;
      private bool[] T000H10_n109fchVenta ;
      private short[] T000H10_A110cantDias ;
      private bool[] T000H10_n110cantDias ;
      private short[] T000H10_A132OrdenEmpFac ;
      private bool[] T000H10_n132OrdenEmpFac ;
      private String[] T000H10_A133OrdenProceso ;
      private bool[] T000H10_n133OrdenProceso ;
      private decimal[] T000H10_A161OrdenSubtotal ;
      private bool[] T000H10_n161OrdenSubtotal ;
      private decimal[] T000H10_A162OrdenValInds ;
      private bool[] T000H10_n162OrdenValInds ;
      private decimal[] T000H10_A163OrdenValEnrq ;
      private bool[] T000H10_n163OrdenValEnrq ;
      private decimal[] T000H10_A165OrdenValCal ;
      private bool[] T000H10_n165OrdenValCal ;
      private decimal[] T000H10_A166OrdenValPint ;
      private bool[] T000H10_n166OrdenValPint ;
      private decimal[] T000H10_A167OrdenValEstr ;
      private bool[] T000H10_n167OrdenValEstr ;
      private decimal[] T000H10_A168OrdenValOtrs ;
      private bool[] T000H10_n168OrdenValOtrs ;
      private DateTime[] T000H10_A172OrdenfchEnt ;
      private bool[] T000H10_n172OrdenfchEnt ;
      private int[] T000H10_A192OrdenPed ;
      private bool[] T000H10_n192OrdenPed ;
      private String[] T000H10_A195OrdenFacNomb ;
      private bool[] T000H10_n195OrdenFacNomb ;
      private short[] T000H10_A210OrdenUltSec ;
      private bool[] T000H10_n210OrdenUltSec ;
      private int[] T000H10_A401OrdenNroDesp ;
      private bool[] T000H10_n401OrdenNroDesp ;
      private short[] T000H10_A1EmpID ;
      private short[] T000H10_A5ClienteID ;
      private short[] T000H10_A26OrdenMarcaID ;
      private short[] T000H10_A8VehiculoID ;
      private short[] T000H10_A9vendedorID ;
      private short[] T000H10_A10protID ;
      private short[] T000H10_A17tipOrdID ;
      private String[] T000H10_A108urlPdf ;
      private bool[] T000H10_n108urlPdf ;
      private String[] T000H10_A112documento ;
      private bool[] T000H10_n112documento ;
      private String[] T000H10_A152OrdenPdf ;
      private bool[] T000H10_n152OrdenPdf ;
      private String[] T000H10_A153OrdenActaPdf ;
      private bool[] T000H10_n153OrdenActaPdf ;
      private String[] T000H42_A44empdsc ;
      private bool[] T000H42_n44empdsc ;
      private String[] T000H43_A57ClienteDsc ;
      private bool[] T000H43_n57ClienteDsc ;
      private decimal[] T000H45_A255OrdenObreSuma ;
      private bool[] T000H45_n255OrdenObreSuma ;
      private String[] T000H46_A68VehiculoPlaca ;
      private bool[] T000H46_n68VehiculoPlaca ;
      private String[] T000H46_A69VehiculoChasis ;
      private bool[] T000H46_n69VehiculoChasis ;
      private String[] T000H47_A104tipOrdDsc ;
      private bool[] T000H47_n104tipOrdDsc ;
      private String[] T000H48_A72vendedorDsc ;
      private bool[] T000H48_n72vendedorDsc ;
      private String[] T000H49_A74protDsc ;
      private bool[] T000H49_n74protDsc ;
      private short[] T000H51_A1EmpID ;
      private short[] T000H51_A5ClienteID ;
      private short[] T000H51_A24OrdenPeriodo ;
      private short[] T000H51_A25OrdenAnio ;
      private short[] T000H51_A22OrdenID ;
      private short[] T000H52_A5ClienteID ;
      private short[] T000H52_A24OrdenPeriodo ;
      private short[] T000H52_A25OrdenAnio ;
      private short[] T000H52_A22OrdenID ;
      private short[] T000H52_A252OrdenObrID ;
      private short[] T000H52_A238ObreID ;
      private String[] T000H52_A253OrdenObreManObra ;
      private bool[] T000H52_n253OrdenObreManObra ;
      private decimal[] T000H52_A254OrdenObreValor ;
      private bool[] T000H52_n254OrdenObreValor ;
      private short[] T000H52_A1EmpID ;
      private short[] T000H53_A1EmpID ;
      private short[] T000H53_A5ClienteID ;
      private short[] T000H53_A24OrdenPeriodo ;
      private short[] T000H53_A25OrdenAnio ;
      private short[] T000H53_A22OrdenID ;
      private short[] T000H53_A252OrdenObrID ;
      private short[] T000H53_A238ObreID ;
      private short[] T000H9_A5ClienteID ;
      private short[] T000H9_A24OrdenPeriodo ;
      private short[] T000H9_A25OrdenAnio ;
      private short[] T000H9_A22OrdenID ;
      private short[] T000H9_A252OrdenObrID ;
      private short[] T000H9_A238ObreID ;
      private String[] T000H9_A253OrdenObreManObra ;
      private bool[] T000H9_n253OrdenObreManObra ;
      private decimal[] T000H9_A254OrdenObreValor ;
      private bool[] T000H9_n254OrdenObreValor ;
      private short[] T000H9_A1EmpID ;
      private short[] T000H8_A5ClienteID ;
      private short[] T000H8_A24OrdenPeriodo ;
      private short[] T000H8_A25OrdenAnio ;
      private short[] T000H8_A22OrdenID ;
      private short[] T000H8_A252OrdenObrID ;
      private short[] T000H8_A238ObreID ;
      private String[] T000H8_A253OrdenObreManObra ;
      private bool[] T000H8_n253OrdenObreManObra ;
      private decimal[] T000H8_A254OrdenObreValor ;
      private bool[] T000H8_n254OrdenObreValor ;
      private short[] T000H8_A1EmpID ;
      private short[] T000H57_A1EmpID ;
      private short[] T000H57_A5ClienteID ;
      private short[] T000H57_A24OrdenPeriodo ;
      private short[] T000H57_A25OrdenAnio ;
      private short[] T000H57_A22OrdenID ;
      private short[] T000H57_A252OrdenObrID ;
      private short[] T000H57_A238ObreID ;
      private String[] T000H5_A146categDsc ;
      private bool[] T000H5_n146categDsc ;
      private short[] T000H58_A5ClienteID ;
      private short[] T000H58_A24OrdenPeriodo ;
      private short[] T000H58_A25OrdenAnio ;
      private short[] T000H58_A22OrdenID ;
      private short[] T000H58_A41OrdenSecId ;
      private String[] T000H58_A146categDsc ;
      private bool[] T000H58_n146categDsc ;
      private String[] T000H58_A148subCatDsc ;
      private bool[] T000H58_n148subCatDsc ;
      private decimal[] T000H58_A150subCatPrec ;
      private bool[] T000H58_n150subCatPrec ;
      private decimal[] T000H58_A208OrdenDetCant ;
      private bool[] T000H58_n208OrdenDetCant ;
      private String[] T000H58_A251OrdenDetDetalle ;
      private bool[] T000H58_n251OrdenDetDetalle ;
      private short[] T000H58_A396OrdenDetDesp ;
      private bool[] T000H58_n396OrdenDetDesp ;
      private short[] T000H58_A397OrdenDesp ;
      private bool[] T000H58_n397OrdenDesp ;
      private short[] T000H58_A1EmpID ;
      private short[] T000H58_A36detTipoProdID ;
      private short[] T000H58_A32categID ;
      private short[] T000H58_A33subCatID ;
      private short[] T000H4_A31tipoProdID ;
      private String[] T000H6_A148subCatDsc ;
      private bool[] T000H6_n148subCatDsc ;
      private decimal[] T000H6_A150subCatPrec ;
      private bool[] T000H6_n150subCatPrec ;
      private String[] T000H59_A146categDsc ;
      private bool[] T000H59_n146categDsc ;
      private String[] T000H60_A148subCatDsc ;
      private bool[] T000H60_n148subCatDsc ;
      private decimal[] T000H60_A150subCatPrec ;
      private bool[] T000H60_n150subCatPrec ;
      private short[] T000H61_A1EmpID ;
      private short[] T000H61_A5ClienteID ;
      private short[] T000H61_A24OrdenPeriodo ;
      private short[] T000H61_A25OrdenAnio ;
      private short[] T000H61_A22OrdenID ;
      private short[] T000H61_A41OrdenSecId ;
      private short[] T000H3_A5ClienteID ;
      private short[] T000H3_A24OrdenPeriodo ;
      private short[] T000H3_A25OrdenAnio ;
      private short[] T000H3_A22OrdenID ;
      private short[] T000H3_A41OrdenSecId ;
      private decimal[] T000H3_A208OrdenDetCant ;
      private bool[] T000H3_n208OrdenDetCant ;
      private String[] T000H3_A251OrdenDetDetalle ;
      private bool[] T000H3_n251OrdenDetDetalle ;
      private short[] T000H3_A396OrdenDetDesp ;
      private bool[] T000H3_n396OrdenDetDesp ;
      private short[] T000H3_A397OrdenDesp ;
      private bool[] T000H3_n397OrdenDesp ;
      private short[] T000H3_A1EmpID ;
      private short[] T000H3_A36detTipoProdID ;
      private short[] T000H3_A32categID ;
      private short[] T000H3_A33subCatID ;
      private short[] T000H2_A5ClienteID ;
      private short[] T000H2_A24OrdenPeriodo ;
      private short[] T000H2_A25OrdenAnio ;
      private short[] T000H2_A22OrdenID ;
      private short[] T000H2_A41OrdenSecId ;
      private decimal[] T000H2_A208OrdenDetCant ;
      private bool[] T000H2_n208OrdenDetCant ;
      private String[] T000H2_A251OrdenDetDetalle ;
      private bool[] T000H2_n251OrdenDetDetalle ;
      private short[] T000H2_A396OrdenDetDesp ;
      private bool[] T000H2_n396OrdenDetDesp ;
      private short[] T000H2_A397OrdenDesp ;
      private bool[] T000H2_n397OrdenDesp ;
      private short[] T000H2_A1EmpID ;
      private short[] T000H2_A36detTipoProdID ;
      private short[] T000H2_A32categID ;
      private short[] T000H2_A33subCatID ;
      private String[] T000H65_A146categDsc ;
      private bool[] T000H65_n146categDsc ;
      private String[] T000H66_A148subCatDsc ;
      private bool[] T000H66_n148subCatDsc ;
      private decimal[] T000H66_A150subCatPrec ;
      private bool[] T000H66_n150subCatPrec ;
      private short[] T000H67_A1EmpID ;
      private short[] T000H67_A5ClienteID ;
      private short[] T000H67_A24OrdenPeriodo ;
      private short[] T000H67_A25OrdenAnio ;
      private short[] T000H67_A22OrdenID ;
      private short[] T000H67_A41OrdenSecId ;
      private String[] T000H68_A3UsuCod ;
      private String[] T000H68_A398UsuAlias ;
      private bool[] T000H68_n398UsuAlias ;
      private short[] T000H69_A20ProcID ;
      private String[] T000H69_A129ProcAbre ;
      private bool[] T000H69_n129ProcAbre ;
      private String[] T000H69_A128ProcDsc ;
      private bool[] T000H69_n128ProcDsc ;
      private short[] T000H70_A1EmpID ;
      private String[] T000H70_A44empdsc ;
      private bool[] T000H70_n44empdsc ;
      private String[] T000H70_A45EmpEst ;
      private bool[] T000H70_n45EmpEst ;
      private short[] T000H71_A1EmpID ;
      private short[] T000H71_A6MarcaID ;
      private String[] T000H71_A62MarcaDsc ;
      private bool[] T000H71_n62MarcaDsc ;
      private short[] T000H72_A1EmpID ;
      private short[] T000H72_A6MarcaID ;
      private short[] T000H72_A7ModeloID ;
      private String[] T000H72_A64ModeloDsc ;
      private bool[] T000H72_n64ModeloDsc ;
      private short[] T000H73_A1EmpID ;
      private short[] T000H73_A5ClienteID ;
      private String[] T000H73_A57ClienteDsc ;
      private bool[] T000H73_n57ClienteDsc ;
      private short[] T000H74_A1EmpID ;
      private short[] T000H74_A9vendedorID ;
      private String[] T000H74_A72vendedorDsc ;
      private bool[] T000H74_n72vendedorDsc ;
      private String[] T000H74_A73vendedorEst ;
      private bool[] T000H74_n73vendedorEst ;
      private short[] T000H75_A1EmpID ;
      private short[] T000H75_A17tipOrdID ;
      private String[] T000H75_A104tipOrdDsc ;
      private bool[] T000H75_n104tipOrdDsc ;
      private short[] T000H76_A1EmpID ;
      private short[] T000H76_A10protID ;
      private String[] T000H76_A74protDsc ;
      private bool[] T000H76_n74protDsc ;
      private String[] T000H77_A239ObreCedula ;
      private short[] T000H77_A238ObreID ;
      private String[] T000H77_A244ObreNombre ;
      private short[] T000H78_A1EmpID ;
      private short[] T000H78_A31tipoProdID ;
      private String[] T000H78_A144tipoProdDsc ;
      private bool[] T000H78_n144tipoProdDsc ;
      private short[] T000H79_A1EmpID ;
      private short[] T000H79_A32categID ;
      private String[] T000H79_A146categDsc ;
      private bool[] T000H79_n146categDsc ;
      private short[] T000H79_A31tipoProdID ;
      private short[] T000H80_A6MarcaID ;
      private short[] T000H81_A6MarcaID ;
      private short[] T000H82_A31tipoProdID ;
      private String[] T000H83_A146categDsc ;
      private bool[] T000H83_n146categDsc ;
      private String[] T000H84_A148subCatDsc ;
      private bool[] T000H84_n148subCatDsc ;
      private decimal[] T000H84_A150subCatPrec ;
      private bool[] T000H84_n150subCatPrec ;
      private short[] T000H7_A31tipoProdID ;
      private short[] T000H19_A6MarcaID ;
      private SdtTransactionContext AV29TrnContext ;
      private SdtTransactionContext_Attribute AV30TrnContextAtt ;
   }

   public class ordenproduccion__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new UpdateCursor(def[31])
         ,new UpdateCursor(def[32])
         ,new UpdateCursor(def[33])
         ,new UpdateCursor(def[34])
         ,new UpdateCursor(def[35])
         ,new UpdateCursor(def[36])
         ,new ForEachCursor(def[37])
         ,new ForEachCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new ForEachCursor(def[42])
         ,new ForEachCursor(def[43])
         ,new UpdateCursor(def[44])
         ,new ForEachCursor(def[45])
         ,new ForEachCursor(def[46])
         ,new ForEachCursor(def[47])
         ,new UpdateCursor(def[48])
         ,new UpdateCursor(def[49])
         ,new UpdateCursor(def[50])
         ,new ForEachCursor(def[51])
         ,new ForEachCursor(def[52])
         ,new ForEachCursor(def[53])
         ,new ForEachCursor(def[54])
         ,new ForEachCursor(def[55])
         ,new UpdateCursor(def[56])
         ,new UpdateCursor(def[57])
         ,new UpdateCursor(def[58])
         ,new ForEachCursor(def[59])
         ,new ForEachCursor(def[60])
         ,new ForEachCursor(def[61])
         ,new ForEachCursor(def[62])
         ,new ForEachCursor(def[63])
         ,new ForEachCursor(def[64])
         ,new ForEachCursor(def[65])
         ,new ForEachCursor(def[66])
         ,new ForEachCursor(def[67])
         ,new ForEachCursor(def[68])
         ,new ForEachCursor(def[69])
         ,new ForEachCursor(def[70])
         ,new ForEachCursor(def[71])
         ,new ForEachCursor(def[72])
         ,new ForEachCursor(def[73])
         ,new ForEachCursor(def[74])
         ,new ForEachCursor(def[75])
         ,new ForEachCursor(def[76])
         ,new ForEachCursor(def[77])
         ,new ForEachCursor(def[78])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000H7 ;
          prmT000H7 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H19 ;
          prmT000H19 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H23 ;
          prmT000H23 = new Object[] {
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          String cmdBufferT000H23 ;
          cmdBufferT000H23=" SELECT TM1.[OrdenPeriodo], TM1.[OrdenAnio], TM1.[OrdenID], TM1.[OrdenUser], TM1.[OrdenEst], T2.[empdsc], T3.[ClienteDsc], T5.[VehiculoPlaca], T5.[VehiculoChasis], TM1.[OrdenModeloID], TM1.[OrdenFch], T6.[tipOrdDsc], T7.[vendedorDsc], TM1.[facturaNro], TM1.[representane], TM1.[ordenNroPed], T8.[protDsc], TM1.[fchVenta], TM1.[cantDias], TM1.[OrdenEmpFac], TM1.[OrdenProceso], TM1.[OrdenSubtotal], TM1.[OrdenValInds], TM1.[OrdenValEnrq], TM1.[OrdenValCal], TM1.[OrdenValPint], TM1.[OrdenValEstr], TM1.[OrdenValOtrs], TM1.[OrdenfchEnt], TM1.[OrdenPed], TM1.[OrdenFacNomb], TM1.[OrdenUltSec], TM1.[OrdenNroDesp], TM1.[EmpID], TM1.[ClienteID], TM1.[OrdenMarcaID], TM1.[VehiculoID], TM1.[vendedorID], TM1.[protID], TM1.[tipOrdID], COALESCE( T4.[OrdenObreSuma], 0) AS OrdenObreSuma, TM1.[urlPdf], TM1.[documento], TM1.[OrdenPdf], TM1.[OrdenActaPdf] FROM ((((((([OrdenProduccion] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Clientes] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[ClienteID] = TM1.[ClienteID]) LEFT JOIN (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (NOLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T4 ON T4.[EmpID] = TM1.[EmpID] AND T4.[ClienteID] = TM1.[ClienteID] AND T4.[OrdenPeriodo] = TM1.[OrdenPeriodo] AND T4.[OrdenAnio] = TM1.[OrdenAnio] AND T4.[OrdenID] = TM1.[OrdenID]) INNER JOIN [Vehiculos] T5 WITH (NOLOCK) ON T5.[EmpID] = TM1.[EmpID] AND T5.[VehiculoID] = TM1.[VehiculoID]) INNER JOIN [TipoOrdenPro] T6 WITH (NOLOCK) ON T6.[EmpID] = TM1.[EmpID] AND T6.[tipOrdID] = TM1.[tipOrdID]) INNER JOIN [Vendedor] T7 WITH (NOLOCK) ON T7.[EmpID] = TM1.[EmpID] AND T7.[vendedorID] = TM1.[vendedorID]) INNER "
          + " JOIN [Prototipo] T8 WITH (NOLOCK) ON T8.[EmpID] = TM1.[EmpID] AND T8.[protID] = TM1.[protID]) WHERE TM1.[OrdenPeriodo] = @OrdenPeriodo and TM1.[OrdenAnio] = @OrdenAnio and TM1.[OrdenID] = @OrdenID and TM1.[EmpID] = @EmpID and TM1.[ClienteID] = @ClienteID ORDER BY TM1.[EmpID], TM1.[ClienteID], TM1.[OrdenPeriodo], TM1.[OrdenAnio], TM1.[OrdenID]  OPTION (FAST 100)" ;
          Object[] prmT000H12 ;
          prmT000H12 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H15 ;
          prmT000H15 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H16 ;
          prmT000H16 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H17 ;
          prmT000H17 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H18 ;
          prmT000H18 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipOrdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H13 ;
          prmT000H13 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H21 ;
          prmT000H21 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H24 ;
          prmT000H24 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H14 ;
          prmT000H14 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenMarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H25 ;
          prmT000H25 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H26 ;
          prmT000H26 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H27 ;
          prmT000H27 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H28 ;
          prmT000H28 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipOrdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H29 ;
          prmT000H29 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H31 ;
          prmT000H31 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H32 ;
          prmT000H32 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H11 ;
          prmT000H11 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H33 ;
          prmT000H33 = new Object[] {
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H34 ;
          prmT000H34 = new Object[] {
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H10 ;
          prmT000H10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H35 ;
          prmT000H35 = new Object[] {
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenUser",SqlDbType.Char,40,0} ,
          new Object[] {"@OrdenEst",SqlDbType.Char,1,0} ,
          new Object[] {"@OrdenModeloID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@facturaNro",SqlDbType.Int,8,0} ,
          new Object[] {"@representane",SqlDbType.Char,50,0} ,
          new Object[] {"@ordenNroPed",SqlDbType.Int,8,0} ,
          new Object[] {"@urlPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@fchVenta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@cantDias",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@documento",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@OrdenEmpFac",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@OrdenPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@OrdenActaPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@OrdenSubtotal",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValInds",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValEnrq",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValCal",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValPint",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValEstr",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValOtrs",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenfchEnt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OrdenPed",SqlDbType.Int,8,0} ,
          new Object[] {"@OrdenFacNomb",SqlDbType.Char,40,0} ,
          new Object[] {"@OrdenUltSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenNroDesp",SqlDbType.Int,6,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenMarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipOrdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H36 ;
          prmT000H36 = new Object[] {
          new Object[] {"@OrdenUser",SqlDbType.Char,40,0} ,
          new Object[] {"@OrdenEst",SqlDbType.Char,1,0} ,
          new Object[] {"@OrdenModeloID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenFch",SqlDbType.DateTime,8,0} ,
          new Object[] {"@facturaNro",SqlDbType.Int,8,0} ,
          new Object[] {"@representane",SqlDbType.Char,50,0} ,
          new Object[] {"@ordenNroPed",SqlDbType.Int,8,0} ,
          new Object[] {"@fchVenta",SqlDbType.DateTime,8,0} ,
          new Object[] {"@cantDias",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenEmpFac",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenProceso",SqlDbType.VarChar,5,0} ,
          new Object[] {"@OrdenSubtotal",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValInds",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValEnrq",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValCal",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValPint",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValEstr",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenValOtrs",SqlDbType.Decimal,10,3} ,
          new Object[] {"@OrdenfchEnt",SqlDbType.DateTime,8,0} ,
          new Object[] {"@OrdenPed",SqlDbType.Int,8,0} ,
          new Object[] {"@OrdenFacNomb",SqlDbType.Char,40,0} ,
          new Object[] {"@OrdenUltSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenNroDesp",SqlDbType.Int,6,0} ,
          new Object[] {"@OrdenMarcaID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipOrdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H37 ;
          prmT000H37 = new Object[] {
          new Object[] {"@urlPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H38 ;
          prmT000H38 = new Object[] {
          new Object[] {"@documento",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H39 ;
          prmT000H39 = new Object[] {
          new Object[] {"@OrdenPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H40 ;
          prmT000H40 = new Object[] {
          new Object[] {"@OrdenActaPdf",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H41 ;
          prmT000H41 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H50 ;
          prmT000H50 = new Object[] {
          new Object[] {"@OrdenUltSec",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H51 ;
          prmT000H51 = new Object[] {
          } ;
          Object[] prmT000H52 ;
          prmT000H52 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H53 ;
          prmT000H53 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H9 ;
          prmT000H9 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H8 ;
          prmT000H8 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H54 ;
          prmT000H54 = new Object[] {
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObreManObra",SqlDbType.VarChar,50,0} ,
          new Object[] {"@OrdenObreValor",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H55 ;
          prmT000H55 = new Object[] {
          new Object[] {"@OrdenObreManObra",SqlDbType.VarChar,50,0} ,
          new Object[] {"@OrdenObreValor",SqlDbType.Decimal,10,2} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H56 ;
          prmT000H56 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenObrID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ObreID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H57 ;
          prmT000H57 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H58 ;
          prmT000H58 = new Object[] {
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H5 ;
          prmT000H5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H6 ;
          prmT000H6 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H4 ;
          prmT000H4 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H59 ;
          prmT000H59 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H60 ;
          prmT000H60 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H61 ;
          prmT000H61 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H3 ;
          prmT000H3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H2 ;
          prmT000H2 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H62 ;
          prmT000H62 = new Object[] {
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenDetCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@OrdenDetDetalle",SqlDbType.VarChar,20,0} ,
          new Object[] {"@OrdenDetDesp",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@OrdenDesp",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H63 ;
          prmT000H63 = new Object[] {
          new Object[] {"@OrdenDetCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@OrdenDetDetalle",SqlDbType.VarChar,20,0} ,
          new Object[] {"@OrdenDetDesp",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@OrdenDesp",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H64 ;
          prmT000H64 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenSecId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H65 ;
          prmT000H65 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H66 ;
          prmT000H66 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H67 ;
          prmT000H67 = new Object[] {
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H68 ;
          prmT000H68 = new Object[] {
          } ;
          Object[] prmT000H69 ;
          prmT000H69 = new Object[] {
          } ;
          Object[] prmT000H70 ;
          prmT000H70 = new Object[] {
          } ;
          Object[] prmT000H71 ;
          prmT000H71 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H72 ;
          prmT000H72 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV22MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H73 ;
          prmT000H73 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H74 ;
          prmT000H74 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H75 ;
          prmT000H75 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H76 ;
          prmT000H76 = new Object[] {
          new Object[] {"@AV10EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H77 ;
          prmT000H77 = new Object[] {
          } ;
          Object[] prmT000H78 ;
          prmT000H78 = new Object[] {
          } ;
          Object[] prmT000H79 ;
          prmT000H79 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H42 ;
          prmT000H42 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H80 ;
          prmT000H80 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H43 ;
          prmT000H43 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H45 ;
          prmT000H45 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H81 ;
          prmT000H81 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenMarcaID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H48 ;
          prmT000H48 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@vendedorID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H47 ;
          prmT000H47 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@tipOrdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H49 ;
          prmT000H49 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@protID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H46 ;
          prmT000H46 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@VehiculoID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H82 ;
          prmT000H82 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@detTipoProdID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H83 ;
          prmT000H83 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000H84 ;
          prmT000H84 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@categID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@subCatID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000H2", "SELECT [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId], [OrdenDetCant], [OrdenDetDetalle], [OrdenDetDesp], [OrdenDesp], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [OrdenProduccionOpItems] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H2,1,0,true,false )
             ,new CursorDef("T000H3", "SELECT [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId], [OrdenDetCant], [OrdenDetDetalle], [OrdenDetDesp], [OrdenDesp], [EmpID], [detTipoProdID], [categID], [subCatID] FROM [OrdenProduccionOpItems] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H3,1,0,true,false )
             ,new CursorDef("T000H4", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H4,1,0,true,false )
             ,new CursorDef("T000H5", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H5,1,0,true,false )
             ,new CursorDef("T000H6", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H6,1,0,true,false )
             ,new CursorDef("T000H7", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @tipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H7,1,0,true,false )
             ,new CursorDef("T000H8", "SELECT [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID], [OrdenObreManObra], [OrdenObreValor], [EmpID] FROM [OrdenProduccionObr] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenObrID] = @OrdenObrID AND [ObreID] = @ObreID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H8,1,0,true,false )
             ,new CursorDef("T000H9", "SELECT [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID], [OrdenObreManObra], [OrdenObreValor], [EmpID] FROM [OrdenProduccionObr] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenObrID] = @OrdenObrID AND [ObreID] = @ObreID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H9,1,0,true,false )
             ,new CursorDef("T000H10", "SELECT [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenUser], [OrdenEst], [OrdenModeloID], [OrdenFch], [facturaNro], [representane], [ordenNroPed], [fchVenta], [cantDias], [OrdenEmpFac], [OrdenProceso], [OrdenSubtotal], [OrdenValInds], [OrdenValEnrq], [OrdenValCal], [OrdenValPint], [OrdenValEstr], [OrdenValOtrs], [OrdenfchEnt], [OrdenPed], [OrdenFacNomb], [OrdenUltSec], [OrdenNroDesp], [EmpID], [ClienteID], [OrdenMarcaID], [VehiculoID], [vendedorID], [protID], [tipOrdID], [urlPdf], [documento], [OrdenPdf], [OrdenActaPdf] FROM [OrdenProduccion] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H10,1,0,true,false )
             ,new CursorDef("T000H11", "SELECT [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenUser], [OrdenEst], [OrdenModeloID], [OrdenFch], [facturaNro], [representane], [ordenNroPed], [fchVenta], [cantDias], [OrdenEmpFac], [OrdenProceso], [OrdenSubtotal], [OrdenValInds], [OrdenValEnrq], [OrdenValCal], [OrdenValPint], [OrdenValEstr], [OrdenValOtrs], [OrdenfchEnt], [OrdenPed], [OrdenFacNomb], [OrdenUltSec], [OrdenNroDesp], [EmpID], [ClienteID], [OrdenMarcaID], [VehiculoID], [vendedorID], [protID], [tipOrdID], [urlPdf], [documento], [OrdenPdf], [OrdenActaPdf] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H11,1,0,true,false )
             ,new CursorDef("T000H12", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H12,1,0,true,false )
             ,new CursorDef("T000H13", "SELECT [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H13,1,0,true,false )
             ,new CursorDef("T000H14", "SELECT [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @OrdenMarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H14,1,0,true,false )
             ,new CursorDef("T000H15", "SELECT [VehiculoPlaca], [VehiculoChasis] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H15,1,0,true,false )
             ,new CursorDef("T000H16", "SELECT [vendedorDsc] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H16,1,0,true,false )
             ,new CursorDef("T000H17", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H17,1,0,true,false )
             ,new CursorDef("T000H18", "SELECT [tipOrdDsc] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @tipOrdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H18,1,0,true,false )
             ,new CursorDef("T000H19", "SELECT [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H19,1,0,true,false )
             ,new CursorDef("T000H21", "SELECT COALESCE( T1.[OrdenObreSuma], 0) AS OrdenObreSuma FROM (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (UPDLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[ClienteID] = @ClienteID AND T1.[OrdenPeriodo] = @OrdenPeriodo AND T1.[OrdenAnio] = @OrdenAnio AND T1.[OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H21,1,0,true,false )
             ,new CursorDef("T000H23", cmdBufferT000H23,true, GxErrorMask.GX_NOMASK, false, this,prmT000H23,100,0,true,false )
             ,new CursorDef("T000H24", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H24,1,0,true,false )
             ,new CursorDef("T000H25", "SELECT [VehiculoPlaca], [VehiculoChasis] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H25,1,0,true,false )
             ,new CursorDef("T000H26", "SELECT [vendedorDsc] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H26,1,0,true,false )
             ,new CursorDef("T000H27", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H27,1,0,true,false )
             ,new CursorDef("T000H28", "SELECT [tipOrdDsc] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @tipOrdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H28,1,0,true,false )
             ,new CursorDef("T000H29", "SELECT [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H29,1,0,true,false )
             ,new CursorDef("T000H31", "SELECT COALESCE( T1.[OrdenObreSuma], 0) AS OrdenObreSuma FROM (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (UPDLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[ClienteID] = @ClienteID AND T1.[OrdenPeriodo] = @OrdenPeriodo AND T1.[OrdenAnio] = @OrdenAnio AND T1.[OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H31,1,0,true,false )
             ,new CursorDef("T000H32", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H32,1,0,true,false )
             ,new CursorDef("T000H33", "SELECT TOP 1 [OrdenPeriodo], [OrdenAnio], [OrdenID], [EmpID], [ClienteID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE ( [OrdenPeriodo] > @OrdenPeriodo or [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] > @OrdenAnio or [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [OrdenID] > @OrdenID or [OrdenID] = @OrdenID and [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [EmpID] > @EmpID or [EmpID] = @EmpID and [OrdenID] = @OrdenID and [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [ClienteID] > @ClienteID) ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H33,1,0,true,true )
             ,new CursorDef("T000H34", "SELECT TOP 1 [OrdenPeriodo], [OrdenAnio], [OrdenID], [EmpID], [ClienteID] FROM [OrdenProduccion] WITH (NOLOCK) WHERE ( [OrdenPeriodo] < @OrdenPeriodo or [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] < @OrdenAnio or [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [OrdenID] < @OrdenID or [OrdenID] = @OrdenID and [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [EmpID] < @EmpID or [EmpID] = @EmpID and [OrdenID] = @OrdenID and [OrdenAnio] = @OrdenAnio and [OrdenPeriodo] = @OrdenPeriodo and [ClienteID] < @ClienteID) ORDER BY [EmpID] DESC, [ClienteID] DESC, [OrdenPeriodo] DESC, [OrdenAnio] DESC, [OrdenID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H34,1,0,true,true )
             ,new CursorDef("T000H35", "INSERT INTO [OrdenProduccion]([OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenUser], [OrdenEst], [OrdenModeloID], [OrdenFch], [facturaNro], [representane], [ordenNroPed], [urlPdf], [fchVenta], [cantDias], [documento], [OrdenEmpFac], [OrdenProceso], [OrdenPdf], [OrdenActaPdf], [OrdenSubtotal], [OrdenValInds], [OrdenValEnrq], [OrdenValCal], [OrdenValPint], [OrdenValEstr], [OrdenValOtrs], [OrdenfchEnt], [OrdenPed], [OrdenFacNomb], [OrdenUltSec], [OrdenNroDesp], [EmpID], [ClienteID], [OrdenMarcaID], [VehiculoID], [vendedorID], [protID], [tipOrdID]) VALUES(@OrdenPeriodo, @OrdenAnio, @OrdenID, @OrdenUser, @OrdenEst, @OrdenModeloID, @OrdenFch, @facturaNro, @representane, @ordenNroPed, @urlPdf, @fchVenta, @cantDias, @documento, @OrdenEmpFac, @OrdenProceso, @OrdenPdf, @OrdenActaPdf, @OrdenSubtotal, @OrdenValInds, @OrdenValEnrq, @OrdenValCal, @OrdenValPint, @OrdenValEstr, @OrdenValOtrs, @OrdenfchEnt, @OrdenPed, @OrdenFacNomb, @OrdenUltSec, @OrdenNroDesp, @EmpID, @ClienteID, @OrdenMarcaID, @VehiculoID, @vendedorID, @protID, @tipOrdID)", GxErrorMask.GX_NOMASK,prmT000H35)
             ,new CursorDef("T000H36", "UPDATE [OrdenProduccion] SET [OrdenUser]=@OrdenUser, [OrdenEst]=@OrdenEst, [OrdenModeloID]=@OrdenModeloID, [OrdenFch]=@OrdenFch, [facturaNro]=@facturaNro, [representane]=@representane, [ordenNroPed]=@ordenNroPed, [fchVenta]=@fchVenta, [cantDias]=@cantDias, [OrdenEmpFac]=@OrdenEmpFac, [OrdenProceso]=@OrdenProceso, [OrdenSubtotal]=@OrdenSubtotal, [OrdenValInds]=@OrdenValInds, [OrdenValEnrq]=@OrdenValEnrq, [OrdenValCal]=@OrdenValCal, [OrdenValPint]=@OrdenValPint, [OrdenValEstr]=@OrdenValEstr, [OrdenValOtrs]=@OrdenValOtrs, [OrdenfchEnt]=@OrdenfchEnt, [OrdenPed]=@OrdenPed, [OrdenFacNomb]=@OrdenFacNomb, [OrdenUltSec]=@OrdenUltSec, [OrdenNroDesp]=@OrdenNroDesp, [OrdenMarcaID]=@OrdenMarcaID, [VehiculoID]=@VehiculoID, [vendedorID]=@vendedorID, [protID]=@protID, [tipOrdID]=@tipOrdID  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H36)
             ,new CursorDef("T000H37", "UPDATE [OrdenProduccion] SET [urlPdf]=@urlPdf  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H37)
             ,new CursorDef("T000H38", "UPDATE [OrdenProduccion] SET [documento]=@documento  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H38)
             ,new CursorDef("T000H39", "UPDATE [OrdenProduccion] SET [OrdenPdf]=@OrdenPdf  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H39)
             ,new CursorDef("T000H40", "UPDATE [OrdenProduccion] SET [OrdenActaPdf]=@OrdenActaPdf  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H40)
             ,new CursorDef("T000H41", "DELETE FROM [OrdenProduccion]  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H41)
             ,new CursorDef("T000H42", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H42,1,0,true,false )
             ,new CursorDef("T000H43", "SELECT [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H43,1,0,true,false )
             ,new CursorDef("T000H45", "SELECT COALESCE( T1.[OrdenObreSuma], 0) AS OrdenObreSuma FROM (SELECT SUM([OrdenObreValor]) AS OrdenObreSuma, [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccionObr] WITH (UPDLOCK) GROUP BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ) T1 WHERE T1.[EmpID] = @EmpID AND T1.[ClienteID] = @ClienteID AND T1.[OrdenPeriodo] = @OrdenPeriodo AND T1.[OrdenAnio] = @OrdenAnio AND T1.[OrdenID] = @OrdenID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H45,1,0,true,false )
             ,new CursorDef("T000H46", "SELECT [VehiculoPlaca], [VehiculoChasis] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [VehiculoID] = @VehiculoID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H46,1,0,true,false )
             ,new CursorDef("T000H47", "SELECT [tipOrdDsc] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipOrdID] = @tipOrdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H47,1,0,true,false )
             ,new CursorDef("T000H48", "SELECT [vendedorDsc] FROM [Vendedor] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [vendedorID] = @vendedorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H48,1,0,true,false )
             ,new CursorDef("T000H49", "SELECT [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [protID] = @protID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H49,1,0,true,false )
             ,new CursorDef("T000H50", "UPDATE [OrdenProduccion] SET [OrdenUltSec]=@OrdenUltSec  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK,prmT000H50)
             ,new CursorDef("T000H51", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] FROM [OrdenProduccion] WITH (NOLOCK) ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H51,100,0,true,false )
             ,new CursorDef("T000H52", "SELECT [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID], [OrdenObreManObra], [OrdenObreValor], [EmpID] FROM [OrdenProduccionObr] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [ClienteID] = @ClienteID and [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] = @OrdenAnio and [OrdenID] = @OrdenID and [OrdenObrID] = @OrdenObrID and [ObreID] = @ObreID ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H52,11,0,true,false )
             ,new CursorDef("T000H53", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID] FROM [OrdenProduccionObr] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenObrID] = @OrdenObrID AND [ObreID] = @ObreID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H53,1,0,true,false )
             ,new CursorDef("T000H54", "INSERT INTO [OrdenProduccionObr]([ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID], [OrdenObreManObra], [OrdenObreValor], [EmpID]) VALUES(@ClienteID, @OrdenPeriodo, @OrdenAnio, @OrdenID, @OrdenObrID, @ObreID, @OrdenObreManObra, @OrdenObreValor, @EmpID)", GxErrorMask.GX_NOMASK,prmT000H54)
             ,new CursorDef("T000H55", "UPDATE [OrdenProduccionObr] SET [OrdenObreManObra]=@OrdenObreManObra, [OrdenObreValor]=@OrdenObreValor  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenObrID] = @OrdenObrID AND [ObreID] = @ObreID", GxErrorMask.GX_NOMASK,prmT000H55)
             ,new CursorDef("T000H56", "DELETE FROM [OrdenProduccionObr]  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenObrID] = @OrdenObrID AND [ObreID] = @ObreID", GxErrorMask.GX_NOMASK,prmT000H56)
             ,new CursorDef("T000H57", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID] FROM [OrdenProduccionObr] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [ClienteID] = @ClienteID and [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] = @OrdenAnio and [OrdenID] = @OrdenID ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenObrID], [ObreID] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H57,11,0,true,false )
             ,new CursorDef("T000H58", "SELECT T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID], T1.[OrdenSecId], T2.[categDsc], T3.[subCatDsc], T3.[subCatPrec], T1.[OrdenDetCant], T1.[OrdenDetDetalle], T1.[OrdenDetDesp], T1.[OrdenDesp], T1.[EmpID], T1.[detTipoProdID], T1.[categID], T1.[subCatID] FROM (([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [Categorias] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID]) INNER JOIN [CategoriassubCat] T3 WITH (NOLOCK) ON T3.[EmpID] = T1.[EmpID] AND T3.[categID] = T1.[categID] AND T3.[subCatID] = T1.[subCatID]) WHERE T1.[ClienteID] = @ClienteID and T1.[OrdenPeriodo] = @OrdenPeriodo and T1.[OrdenAnio] = @OrdenAnio and T1.[OrdenID] = @OrdenID and T1.[OrdenSecId] = @OrdenSecId and T1.[EmpID] = @EmpID ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID], T1.[OrdenSecId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H58,11,0,true,false )
             ,new CursorDef("T000H59", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H59,1,0,true,false )
             ,new CursorDef("T000H60", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H60,1,0,true,false )
             ,new CursorDef("T000H61", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId] FROM [OrdenProduccionOpItems] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H61,1,0,true,false )
             ,new CursorDef("T000H62", "INSERT INTO [OrdenProduccionOpItems]([ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId], [OrdenDetCant], [OrdenDetDetalle], [OrdenDetDesp], [OrdenDesp], [EmpID], [detTipoProdID], [categID], [subCatID]) VALUES(@ClienteID, @OrdenPeriodo, @OrdenAnio, @OrdenID, @OrdenSecId, @OrdenDetCant, @OrdenDetDetalle, @OrdenDetDesp, @OrdenDesp, @EmpID, @detTipoProdID, @categID, @subCatID)", GxErrorMask.GX_NOMASK,prmT000H62)
             ,new CursorDef("T000H63", "UPDATE [OrdenProduccionOpItems] SET [OrdenDetCant]=@OrdenDetCant, [OrdenDetDetalle]=@OrdenDetDetalle, [OrdenDetDesp]=@OrdenDetDesp, [OrdenDesp]=@OrdenDesp, [detTipoProdID]=@detTipoProdID, [categID]=@categID, [subCatID]=@subCatID  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId", GxErrorMask.GX_NOMASK,prmT000H63)
             ,new CursorDef("T000H64", "DELETE FROM [OrdenProduccionOpItems]  WHERE [EmpID] = @EmpID AND [ClienteID] = @ClienteID AND [OrdenPeriodo] = @OrdenPeriodo AND [OrdenAnio] = @OrdenAnio AND [OrdenID] = @OrdenID AND [OrdenSecId] = @OrdenSecId", GxErrorMask.GX_NOMASK,prmT000H64)
             ,new CursorDef("T000H65", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H65,1,0,true,false )
             ,new CursorDef("T000H66", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H66,1,0,true,false )
             ,new CursorDef("T000H67", "SELECT [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId] FROM [OrdenProduccionOpItems] WITH (NOLOCK) WHERE [ClienteID] = @ClienteID and [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] = @OrdenAnio and [OrdenID] = @OrdenID and [EmpID] = @EmpID ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID], [OrdenSecId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H67,11,0,true,false )
             ,new CursorDef("T000H68", "SELECT [UsuCod], [UsuAlias] FROM [Usuarios] WITH (NOLOCK) ORDER BY [UsuAlias] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H68,0,0,true,false )
             ,new CursorDef("T000H69", "SELECT [ProcID], [ProcAbre], [ProcDsc] FROM [Procesos] WITH (NOLOCK) ORDER BY [ProcDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H69,0,0,true,false )
             ,new CursorDef("T000H70", "SELECT [EmpID], [empdsc], [EmpEst] FROM [Empresas] WITH (NOLOCK) WHERE [EmpEst] = 'A' ORDER BY [empdsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H70,0,0,true,false )
             ,new CursorDef("T000H71", "SELECT [EmpID], [MarcaID], [MarcaDsc] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @AV10EmpID ORDER BY [MarcaDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H71,0,0,true,false )
             ,new CursorDef("T000H72", "SELECT [EmpID], [MarcaID], [ModeloID], [ModeloDsc] FROM [MarcaModelo] WITH (NOLOCK) WHERE ([EmpID] = @AV10EmpID) AND ([MarcaID] = @AV22MarcaID) ORDER BY [ModeloDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H72,0,0,true,false )
             ,new CursorDef("T000H73", "SELECT [EmpID], [ClienteID], [ClienteDsc] FROM [Clientes] WITH (NOLOCK) WHERE [EmpID] = @AV10EmpID ORDER BY [ClienteDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H73,0,0,true,false )
             ,new CursorDef("T000H74", "SELECT [EmpID], [vendedorID], [vendedorDsc], [vendedorEst] FROM [Vendedor] WITH (NOLOCK) WHERE ([EmpID] = @AV10EmpID) AND ([vendedorEst] = 'A') ORDER BY [vendedorDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H74,0,0,true,false )
             ,new CursorDef("T000H75", "SELECT [EmpID], [tipOrdID], [tipOrdDsc] FROM [TipoOrdenPro] WITH (NOLOCK) WHERE [EmpID] = @AV10EmpID ORDER BY [tipOrdDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H75,0,0,true,false )
             ,new CursorDef("T000H76", "SELECT [EmpID], [protID], [protDsc] FROM [Prototipo] WITH (NOLOCK) WHERE [EmpID] = @AV10EmpID ORDER BY [protDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H76,0,0,true,false )
             ,new CursorDef("T000H77", "SELECT [ObreCedula], [ObreID], RTRIM(LTRIM(COALESCE( [ObrePrApellido], ''))) + ' ' + RTRIM(LTRIM(COALESCE( [ObreSegApellido], ''))) + ' ' + RTRIM(LTRIM(COALESCE( [ObrePrNombre], ''))) + ' ' + RTRIM(LTRIM(COALESCE( [ObreSegNombre], ''))) AS ObreNombre FROM [Obreros] WITH (NOLOCK) ORDER BY [ObreNombre] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H77,0,0,true,false )
             ,new CursorDef("T000H78", "SELECT [EmpID], [tipoProdID], [tipoProdDsc] FROM [TipoProducto] WITH (NOLOCK) ORDER BY [tipoProdDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H78,0,0,true,false )
             ,new CursorDef("T000H79", "SELECT [EmpID], [categID], [categDsc], [tipoProdID] FROM [Categorias] WITH (NOLOCK) WHERE ([EmpID] = @EmpID) AND ([tipoProdID] = @detTipoProdID) ORDER BY [categDsc] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H79,0,0,true,false )
             ,new CursorDef("T000H80", "SELECT [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @MarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H80,1,0,true,false )
             ,new CursorDef("T000H81", "SELECT [MarcaID] FROM [Marca] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [MarcaID] = @OrdenMarcaID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H81,1,0,true,false )
             ,new CursorDef("T000H82", "SELECT [tipoProdID] FROM [TipoProducto] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [tipoProdID] = @detTipoProdID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H82,1,0,true,false )
             ,new CursorDef("T000H83", "SELECT [categDsc] FROM [Categorias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H83,1,0,true,false )
             ,new CursorDef("T000H84", "SELECT [subCatDsc], [subCatPrec] FROM [CategoriassubCat] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [categID] = @categID AND [subCatID] = @subCatID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H84,1,0,true,false )
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
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((short[]) buf[16])[0] = rslt.getShort(13) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((int[]) buf[10])[0] = rslt.getInt(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((int[]) buf[14])[0] = rslt.getInt(10) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                ((short[]) buf[18])[0] = rslt.getShort(12) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(12);
                ((short[]) buf[20])[0] = rslt.getShort(13) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(13);
                ((String[]) buf[22])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(14);
                ((decimal[]) buf[24])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(15);
                ((decimal[]) buf[26])[0] = rslt.getDecimal(16) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(16);
                ((decimal[]) buf[28])[0] = rslt.getDecimal(17) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(17);
                ((decimal[]) buf[30])[0] = rslt.getDecimal(18) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(18);
                ((decimal[]) buf[32])[0] = rslt.getDecimal(19) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(19);
                ((decimal[]) buf[34])[0] = rslt.getDecimal(20) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(20);
                ((decimal[]) buf[36])[0] = rslt.getDecimal(21) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(21);
                ((DateTime[]) buf[38])[0] = rslt.getGXDate(22) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(22);
                ((int[]) buf[40])[0] = rslt.getInt(23) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(23);
                ((String[]) buf[42])[0] = rslt.getString(24, 40) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(24);
                ((short[]) buf[44])[0] = rslt.getShort(25) ;
                ((bool[]) buf[45])[0] = rslt.wasNull(25);
                ((int[]) buf[46])[0] = rslt.getInt(26) ;
                ((bool[]) buf[47])[0] = rslt.wasNull(26);
                ((short[]) buf[48])[0] = rslt.getShort(27) ;
                ((short[]) buf[49])[0] = rslt.getShort(28) ;
                ((short[]) buf[50])[0] = rslt.getShort(29) ;
                ((short[]) buf[51])[0] = rslt.getShort(30) ;
                ((short[]) buf[52])[0] = rslt.getShort(31) ;
                ((short[]) buf[53])[0] = rslt.getShort(32) ;
                ((short[]) buf[54])[0] = rslt.getShort(33) ;
                ((String[]) buf[55])[0] = rslt.getBLOBFile(34, "tmp", "") ;
                ((bool[]) buf[56])[0] = rslt.wasNull(34);
                ((String[]) buf[57])[0] = rslt.getBLOBFile(35, "tmp", "") ;
                ((bool[]) buf[58])[0] = rslt.wasNull(35);
                ((String[]) buf[59])[0] = rslt.getBLOBFile(36, ".pdf", "") ;
                ((bool[]) buf[60])[0] = rslt.wasNull(36);
                ((String[]) buf[61])[0] = rslt.getBLOBFile(37, ".pdf", "") ;
                ((bool[]) buf[62])[0] = rslt.wasNull(37);
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((int[]) buf[10])[0] = rslt.getInt(8) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(8);
                ((String[]) buf[12])[0] = rslt.getString(9, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(9);
                ((int[]) buf[14])[0] = rslt.getInt(10) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                ((short[]) buf[18])[0] = rslt.getShort(12) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(12);
                ((short[]) buf[20])[0] = rslt.getShort(13) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(13);
                ((String[]) buf[22])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(14);
                ((decimal[]) buf[24])[0] = rslt.getDecimal(15) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(15);
                ((decimal[]) buf[26])[0] = rslt.getDecimal(16) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(16);
                ((decimal[]) buf[28])[0] = rslt.getDecimal(17) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(17);
                ((decimal[]) buf[30])[0] = rslt.getDecimal(18) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(18);
                ((decimal[]) buf[32])[0] = rslt.getDecimal(19) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(19);
                ((decimal[]) buf[34])[0] = rslt.getDecimal(20) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(20);
                ((decimal[]) buf[36])[0] = rslt.getDecimal(21) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(21);
                ((DateTime[]) buf[38])[0] = rslt.getGXDate(22) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(22);
                ((int[]) buf[40])[0] = rslt.getInt(23) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(23);
                ((String[]) buf[42])[0] = rslt.getString(24, 40) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(24);
                ((short[]) buf[44])[0] = rslt.getShort(25) ;
                ((bool[]) buf[45])[0] = rslt.wasNull(25);
                ((int[]) buf[46])[0] = rslt.getInt(26) ;
                ((bool[]) buf[47])[0] = rslt.wasNull(26);
                ((short[]) buf[48])[0] = rslt.getShort(27) ;
                ((short[]) buf[49])[0] = rslt.getShort(28) ;
                ((short[]) buf[50])[0] = rslt.getShort(29) ;
                ((short[]) buf[51])[0] = rslt.getShort(30) ;
                ((short[]) buf[52])[0] = rslt.getShort(31) ;
                ((short[]) buf[53])[0] = rslt.getShort(32) ;
                ((short[]) buf[54])[0] = rslt.getShort(33) ;
                ((String[]) buf[55])[0] = rslt.getBLOBFile(34, "tmp", "") ;
                ((bool[]) buf[56])[0] = rslt.wasNull(34);
                ((String[]) buf[57])[0] = rslt.getBLOBFile(35, "tmp", "") ;
                ((bool[]) buf[58])[0] = rslt.wasNull(35);
                ((String[]) buf[59])[0] = rslt.getBLOBFile(36, ".pdf", "") ;
                ((bool[]) buf[60])[0] = rslt.wasNull(36);
                ((String[]) buf[61])[0] = rslt.getBLOBFile(37, ".pdf", "") ;
                ((bool[]) buf[62])[0] = rslt.wasNull(37);
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
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 18 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getString(7, 50) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((String[]) buf[11])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(9);
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(11);
                ((String[]) buf[18])[0] = rslt.getString(12, 40) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(12);
                ((String[]) buf[20])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(13);
                ((int[]) buf[22])[0] = rslt.getInt(14) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(14);
                ((String[]) buf[24])[0] = rslt.getString(15, 50) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(15);
                ((int[]) buf[26])[0] = rslt.getInt(16) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(16);
                ((String[]) buf[28])[0] = rslt.getString(17, 50) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[30])[0] = rslt.getGXDate(18) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(18);
                ((short[]) buf[32])[0] = rslt.getShort(19) ;
                ((bool[]) buf[33])[0] = rslt.wasNull(19);
                ((short[]) buf[34])[0] = rslt.getShort(20) ;
                ((bool[]) buf[35])[0] = rslt.wasNull(20);
                ((String[]) buf[36])[0] = rslt.getVarchar(21) ;
                ((bool[]) buf[37])[0] = rslt.wasNull(21);
                ((decimal[]) buf[38])[0] = rslt.getDecimal(22) ;
                ((bool[]) buf[39])[0] = rslt.wasNull(22);
                ((decimal[]) buf[40])[0] = rslt.getDecimal(23) ;
                ((bool[]) buf[41])[0] = rslt.wasNull(23);
                ((decimal[]) buf[42])[0] = rslt.getDecimal(24) ;
                ((bool[]) buf[43])[0] = rslt.wasNull(24);
                ((decimal[]) buf[44])[0] = rslt.getDecimal(25) ;
                ((bool[]) buf[45])[0] = rslt.wasNull(25);
                ((decimal[]) buf[46])[0] = rslt.getDecimal(26) ;
                ((bool[]) buf[47])[0] = rslt.wasNull(26);
                ((decimal[]) buf[48])[0] = rslt.getDecimal(27) ;
                ((bool[]) buf[49])[0] = rslt.wasNull(27);
                ((decimal[]) buf[50])[0] = rslt.getDecimal(28) ;
                ((bool[]) buf[51])[0] = rslt.wasNull(28);
                ((DateTime[]) buf[52])[0] = rslt.getGXDate(29) ;
                ((bool[]) buf[53])[0] = rslt.wasNull(29);
                ((int[]) buf[54])[0] = rslt.getInt(30) ;
                ((bool[]) buf[55])[0] = rslt.wasNull(30);
                ((String[]) buf[56])[0] = rslt.getString(31, 40) ;
                ((bool[]) buf[57])[0] = rslt.wasNull(31);
                ((short[]) buf[58])[0] = rslt.getShort(32) ;
                ((bool[]) buf[59])[0] = rslt.wasNull(32);
                ((int[]) buf[60])[0] = rslt.getInt(33) ;
                ((bool[]) buf[61])[0] = rslt.wasNull(33);
                ((short[]) buf[62])[0] = rslt.getShort(34) ;
                ((short[]) buf[63])[0] = rslt.getShort(35) ;
                ((short[]) buf[64])[0] = rslt.getShort(36) ;
                ((short[]) buf[65])[0] = rslt.getShort(37) ;
                ((short[]) buf[66])[0] = rslt.getShort(38) ;
                ((short[]) buf[67])[0] = rslt.getShort(39) ;
                ((short[]) buf[68])[0] = rslt.getShort(40) ;
                ((decimal[]) buf[69])[0] = rslt.getDecimal(41) ;
                ((bool[]) buf[70])[0] = rslt.wasNull(41);
                ((String[]) buf[71])[0] = rslt.getBLOBFile(42, "tmp", "") ;
                ((bool[]) buf[72])[0] = rslt.wasNull(42);
                ((String[]) buf[73])[0] = rslt.getBLOBFile(43, "tmp", "") ;
                ((bool[]) buf[74])[0] = rslt.wasNull(43);
                ((String[]) buf[75])[0] = rslt.getBLOBFile(44, ".pdf", "") ;
                ((bool[]) buf[76])[0] = rslt.wasNull(44);
                ((String[]) buf[77])[0] = rslt.getBLOBFile(45, ".pdf", "") ;
                ((bool[]) buf[78])[0] = rslt.wasNull(45);
                return;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 24 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 26 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 28 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 29 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 37 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 38 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 39 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 40 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 41 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 42 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 43 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 45 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 46 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                return;
             case 47 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 40) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((decimal[]) buf[11])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((String[]) buf[13])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(10);
                ((short[]) buf[15])[0] = rslt.getShort(11) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(11);
                ((short[]) buf[17])[0] = rslt.getShort(12) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(12);
                ((short[]) buf[19])[0] = rslt.getShort(13) ;
                ((short[]) buf[20])[0] = rslt.getShort(14) ;
                ((short[]) buf[21])[0] = rslt.getShort(15) ;
                ((short[]) buf[22])[0] = rslt.getShort(16) ;
                return;
             case 53 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 54 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 55 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 59 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
       }
       getresults60( cursor, rslt, buf) ;
    }

    public void getresults60( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 60 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                return;
             case 61 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 62 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 40) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 63 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 64 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 65 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 66 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                return;
             case 67 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 68 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                return;
             case 69 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 70 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 71 :
                ((String[]) buf[0])[0] = rslt.getString(1, 13) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
             case 72 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                return;
             case 73 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 40) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                return;
             case 74 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 75 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 76 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 77 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 78 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
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
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
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
                   stmt.setNull( 5 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(7, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 10 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(10, (int)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 11 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(11, (String)parms[17], true);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 12 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(12, (DateTime)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 13 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(13, (short)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 14 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(14, (String)parms[23], true);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 15 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(15, (short)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 16 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(16, (String)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 17 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(17, (String)parms[29], true);
                }
                if ( (bool)parms[30] )
                {
                   stmt.setNull( 18 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(18, (String)parms[31], true);
                }
                if ( (bool)parms[32] )
                {
                   stmt.setNull( 19 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(19, (decimal)parms[33]);
                }
                if ( (bool)parms[34] )
                {
                   stmt.setNull( 20 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(20, (decimal)parms[35]);
                }
                if ( (bool)parms[36] )
                {
                   stmt.setNull( 21 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(21, (decimal)parms[37]);
                }
                if ( (bool)parms[38] )
                {
                   stmt.setNull( 22 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(22, (decimal)parms[39]);
                }
                if ( (bool)parms[40] )
                {
                   stmt.setNull( 23 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(23, (decimal)parms[41]);
                }
                if ( (bool)parms[42] )
                {
                   stmt.setNull( 24 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(24, (decimal)parms[43]);
                }
                if ( (bool)parms[44] )
                {
                   stmt.setNull( 25 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(25, (decimal)parms[45]);
                }
                if ( (bool)parms[46] )
                {
                   stmt.setNull( 26 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(26, (DateTime)parms[47]);
                }
                if ( (bool)parms[48] )
                {
                   stmt.setNull( 27 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(27, (int)parms[49]);
                }
                if ( (bool)parms[50] )
                {
                   stmt.setNull( 28 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(28, (String)parms[51]);
                }
                if ( (bool)parms[52] )
                {
                   stmt.setNull( 29 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(29, (short)parms[53]);
                }
                if ( (bool)parms[54] )
                {
                   stmt.setNull( 30 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(30, (int)parms[55]);
                }
                stmt.SetParameter(31, (short)parms[56]);
                stmt.SetParameter(32, (short)parms[57]);
                stmt.SetParameter(33, (short)parms[58]);
                stmt.SetParameter(34, (short)parms[59]);
                stmt.SetParameter(35, (short)parms[60]);
                stmt.SetParameter(36, (short)parms[61]);
                stmt.SetParameter(37, (short)parms[62]);
                return;
             case 31 :
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
                stmt.SetParameter(3, (short)parms[4]);
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
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[8]);
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
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[14]);
                }
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 11 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[20]);
                }
                if ( (bool)parms[21] )
                {
                   stmt.setNull( 12 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(12, (decimal)parms[22]);
                }
                if ( (bool)parms[23] )
                {
                   stmt.setNull( 13 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(13, (decimal)parms[24]);
                }
                if ( (bool)parms[25] )
                {
                   stmt.setNull( 14 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(14, (decimal)parms[26]);
                }
                if ( (bool)parms[27] )
                {
                   stmt.setNull( 15 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(15, (decimal)parms[28]);
                }
                if ( (bool)parms[29] )
                {
                   stmt.setNull( 16 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(16, (decimal)parms[30]);
                }
                if ( (bool)parms[31] )
                {
                   stmt.setNull( 17 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(17, (decimal)parms[32]);
                }
                if ( (bool)parms[33] )
                {
                   stmt.setNull( 18 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(18, (decimal)parms[34]);
                }
                if ( (bool)parms[35] )
                {
                   stmt.setNull( 19 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(19, (DateTime)parms[36]);
                }
                if ( (bool)parms[37] )
                {
                   stmt.setNull( 20 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(20, (int)parms[38]);
                }
                if ( (bool)parms[39] )
                {
                   stmt.setNull( 21 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(21, (String)parms[40]);
                }
                if ( (bool)parms[41] )
                {
                   stmt.setNull( 22 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(22, (short)parms[42]);
                }
                if ( (bool)parms[43] )
                {
                   stmt.setNull( 23 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(23, (int)parms[44]);
                }
                stmt.SetParameter(24, (short)parms[45]);
                stmt.SetParameter(25, (short)parms[46]);
                stmt.SetParameter(26, (short)parms[47]);
                stmt.SetParameter(27, (short)parms[48]);
                stmt.SetParameter(28, (short)parms[49]);
                stmt.SetParameter(29, (short)parms[50]);
                stmt.SetParameter(30, (short)parms[51]);
                stmt.SetParameter(31, (short)parms[52]);
                stmt.SetParameter(32, (short)parms[53]);
                stmt.SetParameter(33, (short)parms[54]);
                return;
             case 32 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                return;
             case 33 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                return;
             case 34 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                return;
             case 35 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (short)parms[2]);
                stmt.SetParameter(3, (short)parms[3]);
                stmt.SetParameter(4, (short)parms[4]);
                stmt.SetParameter(5, (short)parms[5]);
                stmt.SetParameter(6, (short)parms[6]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 37 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 38 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 39 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 41 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 42 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 43 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 44 :
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
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 48 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(8, (decimal)parms[9]);
                }
                stmt.SetParameter(9, (short)parms[10]);
                return;
             case 49 :
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
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (short)parms[8]);
                stmt.SetParameter(8, (short)parms[9]);
                stmt.SetParameter(9, (short)parms[10]);
                return;
             case 50 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 51 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 52 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 53 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 54 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 55 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 56 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(9, (short)parms[12]);
                }
                stmt.SetParameter(10, (short)parms[13]);
                stmt.SetParameter(11, (short)parms[14]);
                stmt.SetParameter(12, (short)parms[15]);
                stmt.SetParameter(13, (short)parms[16]);
                return;
             case 57 :
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
                stmt.SetParameter(5, (short)parms[8]);
                stmt.SetParameter(6, (short)parms[9]);
                stmt.SetParameter(7, (short)parms[10]);
                stmt.SetParameter(8, (short)parms[11]);
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (short)parms[13]);
                stmt.SetParameter(11, (short)parms[14]);
                stmt.SetParameter(12, (short)parms[15]);
                stmt.SetParameter(13, (short)parms[16]);
                return;
             case 58 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 59 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
       setparameters60( cursor, stmt, parms) ;
    }

    public void setparameters60( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 60 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 61 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 65 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 66 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 67 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 68 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 69 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 70 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 73 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 74 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 75 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 76 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 77 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 78 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
       }
    }

 }

}
