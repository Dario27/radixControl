/*
               File: DespBodega_BC
        Description: Despacho Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/27/2022 11:7:9.68
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
   public class despbodega_bc : GXHttpHandler, IGxSilentTrn
   {
      public despbodega_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public despbodega_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow1286( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1286( ) ;
         standaloneModal( ) ;
         AddRow1286( ) ;
         Gx_mode = "INS";
         return  ;
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
               Z1EmpID = A1EmpID;
               Z2AgeID = A2AgeID;
               Z353DespBodNro = A353DespBodNro;
               Z354DespBodOpId = A354DespBodOpId;
               SetMode( "UPD") ;
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

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_120( )
      {
         BeforeValidate1286( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1286( ) ;
            }
            else
            {
               CheckExtendedTable1286( ) ;
               if ( AnyError == 0 )
               {
                  ZM1286( 4) ;
                  ZM1286( 5) ;
                  ZM1286( 6) ;
               }
               CloseExtendedTableCursors1286( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1286( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z355DespBodCodPrd = A355DespBodCodPrd;
            Z356DespBodPrdNombre = A356DespBodPrdNombre;
            Z357DespBodCant = A357DespBodCant;
            Z358DespBodValor = A358DespBodValor;
            Z359DespBodADesp = A359DespBodADesp;
            Z361DespBodCatId = A361DespBodCatId;
            Z42BodCod = A42BodCod;
            Z360DespBodStock = A360DespBodStock;
            Z362DespBodDif = A362DespBodDif;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z44empdsc = A44empdsc;
            Z360DespBodStock = A360DespBodStock;
            Z362DespBodDif = A362DespBodDif;
         }
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            Z46AgeDsc = A46AgeDsc;
            Z360DespBodStock = A360DespBodStock;
            Z362DespBodDif = A362DespBodDif;
         }
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z217BodDsc = A217BodDsc;
            Z360DespBodStock = A360DespBodStock;
            Z362DespBodDif = A362DespBodDif;
         }
         if ( GX_JID == -3 )
         {
            Z353DespBodNro = A353DespBodNro;
            Z354DespBodOpId = A354DespBodOpId;
            Z355DespBodCodPrd = A355DespBodCodPrd;
            Z356DespBodPrdNombre = A356DespBodPrdNombre;
            Z357DespBodCant = A357DespBodCant;
            Z358DespBodValor = A358DespBodValor;
            Z359DespBodADesp = A359DespBodADesp;
            Z361DespBodCatId = A361DespBodCatId;
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z42BodCod = A42BodCod;
            Z44empdsc = A44empdsc;
            Z46AgeDsc = A46AgeDsc;
            Z217BodDsc = A217BodDsc;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1286( )
      {
         /* Using cursor BC00127 */
         pr_default.execute(5, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound86 = 1;
            A44empdsc = BC00127_A44empdsc[0];
            n44empdsc = BC00127_n44empdsc[0];
            A46AgeDsc = BC00127_A46AgeDsc[0];
            n46AgeDsc = BC00127_n46AgeDsc[0];
            A217BodDsc = BC00127_A217BodDsc[0];
            n217BodDsc = BC00127_n217BodDsc[0];
            A355DespBodCodPrd = BC00127_A355DespBodCodPrd[0];
            n355DespBodCodPrd = BC00127_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = BC00127_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = BC00127_n356DespBodPrdNombre[0];
            A357DespBodCant = BC00127_A357DespBodCant[0];
            n357DespBodCant = BC00127_n357DespBodCant[0];
            A358DespBodValor = BC00127_A358DespBodValor[0];
            n358DespBodValor = BC00127_n358DespBodValor[0];
            A359DespBodADesp = BC00127_A359DespBodADesp[0];
            n359DespBodADesp = BC00127_n359DespBodADesp[0];
            A361DespBodCatId = BC00127_A361DespBodCatId[0];
            n361DespBodCatId = BC00127_n361DespBodCatId[0];
            A42BodCod = BC00127_A42BodCod[0];
            ZM1286( -3) ;
         }
         pr_default.close(5);
         OnLoadActions1286( ) ;
      }

      protected void OnLoadActions1286( )
      {
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         A360DespBodStock = GXt_decimal1;
         A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
      }

      protected void CheckExtendedTable1286( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00124 */
         pr_default.execute(2, new Object[] {A1EmpID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
         }
         A44empdsc = BC00124_A44empdsc[0];
         n44empdsc = BC00124_n44empdsc[0];
         pr_default.close(2);
         /* Using cursor BC00126 */
         pr_default.execute(4, new Object[] {A1EmpID, A42BodCod});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Bodegas'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
         }
         A217BodDsc = BC00126_A217BodDsc[0];
         n217BodDsc = BC00126_n217BodDsc[0];
         pr_default.close(4);
         /* Using cursor BC00125 */
         pr_default.execute(3, new Object[] {A1EmpID, A2AgeID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
            AnyError = 1;
         }
         A46AgeDsc = BC00125_A46AgeDsc[0];
         n46AgeDsc = BC00125_n46AgeDsc[0];
         pr_default.close(3);
         GXt_decimal1 = A360DespBodStock;
         new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
         A360DespBodStock = GXt_decimal1;
         A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
      }

      protected void CloseExtendedTableCursors1286( )
      {
         pr_default.close(2);
         pr_default.close(4);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1286( )
      {
         /* Using cursor BC00128 */
         pr_default.execute(6, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound86 = 1;
         }
         else
         {
            RcdFound86 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00123 */
         pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1286( 3) ;
            RcdFound86 = 1;
            A353DespBodNro = BC00123_A353DespBodNro[0];
            A354DespBodOpId = BC00123_A354DespBodOpId[0];
            A355DespBodCodPrd = BC00123_A355DespBodCodPrd[0];
            n355DespBodCodPrd = BC00123_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = BC00123_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = BC00123_n356DespBodPrdNombre[0];
            A357DespBodCant = BC00123_A357DespBodCant[0];
            n357DespBodCant = BC00123_n357DespBodCant[0];
            A358DespBodValor = BC00123_A358DespBodValor[0];
            n358DespBodValor = BC00123_n358DespBodValor[0];
            A359DespBodADesp = BC00123_A359DespBodADesp[0];
            n359DespBodADesp = BC00123_n359DespBodADesp[0];
            A361DespBodCatId = BC00123_A361DespBodCatId[0];
            n361DespBodCatId = BC00123_n361DespBodCatId[0];
            A1EmpID = BC00123_A1EmpID[0];
            A2AgeID = BC00123_A2AgeID[0];
            A42BodCod = BC00123_A42BodCod[0];
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z354DespBodOpId = A354DespBodOpId;
            sMode86 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1286( ) ;
            if ( AnyError == 1 )
            {
               RcdFound86 = 0;
               InitializeNonKey1286( ) ;
            }
            Gx_mode = sMode86;
         }
         else
         {
            RcdFound86 = 0;
            InitializeNonKey1286( ) ;
            sMode86 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode86;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1286( ) ;
         if ( RcdFound86 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_120( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency1286( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00122 */
            pr_default.execute(0, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodega"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z355DespBodCodPrd != BC00122_A355DespBodCodPrd[0] ) || ( StringUtil.StrCmp(Z356DespBodPrdNombre, BC00122_A356DespBodPrdNombre[0]) != 0 ) || ( Z357DespBodCant != BC00122_A357DespBodCant[0] ) || ( Z358DespBodValor != BC00122_A358DespBodValor[0] ) || ( Z359DespBodADesp != BC00122_A359DespBodADesp[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z361DespBodCatId != BC00122_A361DespBodCatId[0] ) || ( Z42BodCod != BC00122_A42BodCod[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"DespBodega"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1286( )
      {
         BeforeValidate1286( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1286( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1286( 0) ;
            CheckOptimisticConcurrency1286( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1286( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1286( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00129 */
                     pr_default.execute(7, new Object[] {A353DespBodNro, A354DespBodOpId, n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n359DespBodADesp, A359DespBodADesp, n361DespBodCatId, A361DespBodCatId, A1EmpID, A2AgeID, A42BodCod});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
                     if ( (pr_default.getStatus(7) == 1) )
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
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
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
               Load1286( ) ;
            }
            EndLevel1286( ) ;
         }
         CloseExtendedTableCursors1286( ) ;
      }

      protected void Update1286( )
      {
         BeforeValidate1286( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1286( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1286( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1286( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1286( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001210 */
                     pr_default.execute(8, new Object[] {n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n359DespBodADesp, A359DespBodADesp, n361DespBodCatId, A361DespBodCatId, A42BodCod, A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"DespBodega"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1286( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
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
            EndLevel1286( ) ;
         }
         CloseExtendedTableCursors1286( ) ;
      }

      protected void DeferredUpdate1286( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1286( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1286( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1286( ) ;
            AfterConfirm1286( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1286( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001211 */
                  pr_default.execute(9, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
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
         sMode86 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1286( ) ;
         Gx_mode = sMode86;
      }

      protected void OnDeleteControls1286( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC001212 */
            pr_default.execute(10, new Object[] {A1EmpID});
            A44empdsc = BC001212_A44empdsc[0];
            n44empdsc = BC001212_n44empdsc[0];
            pr_default.close(10);
            /* Using cursor BC001213 */
            pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
            A46AgeDsc = BC001213_A46AgeDsc[0];
            n46AgeDsc = BC001213_n46AgeDsc[0];
            pr_default.close(11);
            /* Using cursor BC001214 */
            pr_default.execute(12, new Object[] {A1EmpID, A42BodCod});
            A217BodDsc = BC001214_A217BodDsc[0];
            n217BodDsc = BC001214_n217BodDsc[0];
            pr_default.close(12);
            GXt_decimal1 = A360DespBodStock;
            new prcbusstock(context ).execute(  (short)(DateTimeUtil.Year( DateTimeUtil.ServerNow( context, pr_default))),  (short)(DateTimeUtil.Month( DateTimeUtil.ServerNow( context, pr_default))),  A1EmpID,  A2AgeID,  A42BodCod,  A355DespBodCodPrd, out  GXt_decimal1) ;
            A360DespBodStock = GXt_decimal1;
            A362DespBodDif = (short)((A357DespBodCant-A359DespBodADesp));
         }
      }

      protected void EndLevel1286( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1286( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart1286( )
      {
         /* Using cursor BC001215 */
         pr_default.execute(13, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId});
         RcdFound86 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound86 = 1;
            A353DespBodNro = BC001215_A353DespBodNro[0];
            A354DespBodOpId = BC001215_A354DespBodOpId[0];
            A44empdsc = BC001215_A44empdsc[0];
            n44empdsc = BC001215_n44empdsc[0];
            A46AgeDsc = BC001215_A46AgeDsc[0];
            n46AgeDsc = BC001215_n46AgeDsc[0];
            A217BodDsc = BC001215_A217BodDsc[0];
            n217BodDsc = BC001215_n217BodDsc[0];
            A355DespBodCodPrd = BC001215_A355DespBodCodPrd[0];
            n355DespBodCodPrd = BC001215_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = BC001215_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = BC001215_n356DespBodPrdNombre[0];
            A357DespBodCant = BC001215_A357DespBodCant[0];
            n357DespBodCant = BC001215_n357DespBodCant[0];
            A358DespBodValor = BC001215_A358DespBodValor[0];
            n358DespBodValor = BC001215_n358DespBodValor[0];
            A359DespBodADesp = BC001215_A359DespBodADesp[0];
            n359DespBodADesp = BC001215_n359DespBodADesp[0];
            A361DespBodCatId = BC001215_A361DespBodCatId[0];
            n361DespBodCatId = BC001215_n361DespBodCatId[0];
            A1EmpID = BC001215_A1EmpID[0];
            A2AgeID = BC001215_A2AgeID[0];
            A42BodCod = BC001215_A42BodCod[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1286( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound86 = 0;
         ScanKeyLoad1286( ) ;
      }

      protected void ScanKeyLoad1286( )
      {
         sMode86 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound86 = 1;
            A353DespBodNro = BC001215_A353DespBodNro[0];
            A354DespBodOpId = BC001215_A354DespBodOpId[0];
            A44empdsc = BC001215_A44empdsc[0];
            n44empdsc = BC001215_n44empdsc[0];
            A46AgeDsc = BC001215_A46AgeDsc[0];
            n46AgeDsc = BC001215_n46AgeDsc[0];
            A217BodDsc = BC001215_A217BodDsc[0];
            n217BodDsc = BC001215_n217BodDsc[0];
            A355DespBodCodPrd = BC001215_A355DespBodCodPrd[0];
            n355DespBodCodPrd = BC001215_n355DespBodCodPrd[0];
            A356DespBodPrdNombre = BC001215_A356DespBodPrdNombre[0];
            n356DespBodPrdNombre = BC001215_n356DespBodPrdNombre[0];
            A357DespBodCant = BC001215_A357DespBodCant[0];
            n357DespBodCant = BC001215_n357DespBodCant[0];
            A358DespBodValor = BC001215_A358DespBodValor[0];
            n358DespBodValor = BC001215_n358DespBodValor[0];
            A359DespBodADesp = BC001215_A359DespBodADesp[0];
            n359DespBodADesp = BC001215_n359DespBodADesp[0];
            A361DespBodCatId = BC001215_A361DespBodCatId[0];
            n361DespBodCatId = BC001215_n361DespBodCatId[0];
            A1EmpID = BC001215_A1EmpID[0];
            A2AgeID = BC001215_A2AgeID[0];
            A42BodCod = BC001215_A42BodCod[0];
         }
         Gx_mode = sMode86;
      }

      protected void ScanKeyEnd1286( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm1286( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1286( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1286( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1286( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1286( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1286( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1286( )
      {
      }

      protected void send_integrity_lvl_hashes1286( )
      {
      }

      protected void AddRow1286( )
      {
         VarsToRow86( bcDespBodega) ;
      }

      protected void ReadRow1286( )
      {
         RowToVars86( bcDespBodega, 1) ;
      }

      protected void InitializeNonKey1286( )
      {
         A360DespBodStock = 0;
         A44empdsc = "";
         n44empdsc = false;
         A46AgeDsc = "";
         n46AgeDsc = false;
         A42BodCod = 0;
         A217BodDsc = "";
         n217BodDsc = false;
         A355DespBodCodPrd = 0;
         n355DespBodCodPrd = false;
         A356DespBodPrdNombre = "";
         n356DespBodPrdNombre = false;
         A357DespBodCant = 0;
         n357DespBodCant = false;
         A358DespBodValor = 0;
         n358DespBodValor = false;
         A359DespBodADesp = 0;
         n359DespBodADesp = false;
         A361DespBodCatId = 0;
         n361DespBodCatId = false;
         A362DespBodDif = 0;
         Z355DespBodCodPrd = 0;
         Z356DespBodPrdNombre = "";
         Z357DespBodCant = 0;
         Z358DespBodValor = 0;
         Z359DespBodADesp = 0;
         Z361DespBodCatId = 0;
         Z42BodCod = 0;
      }

      protected void InitAll1286( )
      {
         A1EmpID = 0;
         A2AgeID = 0;
         A353DespBodNro = 0;
         A354DespBodOpId = 0;
         InitializeNonKey1286( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow86( SdtDespBodega obj86 )
      {
         obj86.gxTpr_Mode = Gx_mode;
         obj86.gxTpr_Despbodstock = A360DespBodStock;
         obj86.gxTpr_Empdsc = A44empdsc;
         obj86.gxTpr_Agedsc = A46AgeDsc;
         obj86.gxTpr_Bodcod = A42BodCod;
         obj86.gxTpr_Boddsc = A217BodDsc;
         obj86.gxTpr_Despbodcodprd = A355DespBodCodPrd;
         obj86.gxTpr_Despbodprdnombre = A356DespBodPrdNombre;
         obj86.gxTpr_Despbodcant = A357DespBodCant;
         obj86.gxTpr_Despbodvalor = A358DespBodValor;
         obj86.gxTpr_Despbodadesp = A359DespBodADesp;
         obj86.gxTpr_Despbodcatid = A361DespBodCatId;
         obj86.gxTpr_Despboddif = A362DespBodDif;
         obj86.gxTpr_Empid = A1EmpID;
         obj86.gxTpr_Ageid = A2AgeID;
         obj86.gxTpr_Despbodnro = A353DespBodNro;
         obj86.gxTpr_Despbodopid = A354DespBodOpId;
         obj86.gxTpr_Empid_Z = Z1EmpID;
         obj86.gxTpr_Empdsc_Z = Z44empdsc;
         obj86.gxTpr_Ageid_Z = Z2AgeID;
         obj86.gxTpr_Agedsc_Z = Z46AgeDsc;
         obj86.gxTpr_Bodcod_Z = Z42BodCod;
         obj86.gxTpr_Boddsc_Z = Z217BodDsc;
         obj86.gxTpr_Despbodnro_Z = Z353DespBodNro;
         obj86.gxTpr_Despbodopid_Z = Z354DespBodOpId;
         obj86.gxTpr_Despbodcodprd_Z = Z355DespBodCodPrd;
         obj86.gxTpr_Despbodprdnombre_Z = Z356DespBodPrdNombre;
         obj86.gxTpr_Despbodcant_Z = Z357DespBodCant;
         obj86.gxTpr_Despbodvalor_Z = Z358DespBodValor;
         obj86.gxTpr_Despbodadesp_Z = Z359DespBodADesp;
         obj86.gxTpr_Despbodstock_Z = Z360DespBodStock;
         obj86.gxTpr_Despbodcatid_Z = Z361DespBodCatId;
         obj86.gxTpr_Despboddif_Z = Z362DespBodDif;
         obj86.gxTpr_Empdsc_N = (short)(Convert.ToInt16(n44empdsc));
         obj86.gxTpr_Agedsc_N = (short)(Convert.ToInt16(n46AgeDsc));
         obj86.gxTpr_Boddsc_N = (short)(Convert.ToInt16(n217BodDsc));
         obj86.gxTpr_Despbodcodprd_N = (short)(Convert.ToInt16(n355DespBodCodPrd));
         obj86.gxTpr_Despbodprdnombre_N = (short)(Convert.ToInt16(n356DespBodPrdNombre));
         obj86.gxTpr_Despbodcant_N = (short)(Convert.ToInt16(n357DespBodCant));
         obj86.gxTpr_Despbodvalor_N = (short)(Convert.ToInt16(n358DespBodValor));
         obj86.gxTpr_Despbodadesp_N = (short)(Convert.ToInt16(n359DespBodADesp));
         obj86.gxTpr_Despbodcatid_N = (short)(Convert.ToInt16(n361DespBodCatId));
         obj86.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow86( SdtDespBodega obj86 )
      {
         obj86.gxTpr_Empid = A1EmpID;
         obj86.gxTpr_Ageid = A2AgeID;
         obj86.gxTpr_Despbodnro = A353DespBodNro;
         obj86.gxTpr_Despbodopid = A354DespBodOpId;
         return  ;
      }

      public void RowToVars86( SdtDespBodega obj86 ,
                               int forceLoad )
      {
         Gx_mode = obj86.gxTpr_Mode;
         A360DespBodStock = obj86.gxTpr_Despbodstock;
         A44empdsc = obj86.gxTpr_Empdsc;
         n44empdsc = false;
         A46AgeDsc = obj86.gxTpr_Agedsc;
         n46AgeDsc = false;
         A42BodCod = obj86.gxTpr_Bodcod;
         A217BodDsc = obj86.gxTpr_Boddsc;
         n217BodDsc = false;
         A355DespBodCodPrd = obj86.gxTpr_Despbodcodprd;
         n355DespBodCodPrd = false;
         A356DespBodPrdNombre = obj86.gxTpr_Despbodprdnombre;
         n356DespBodPrdNombre = false;
         A357DespBodCant = obj86.gxTpr_Despbodcant;
         n357DespBodCant = false;
         A358DespBodValor = obj86.gxTpr_Despbodvalor;
         n358DespBodValor = false;
         A359DespBodADesp = obj86.gxTpr_Despbodadesp;
         n359DespBodADesp = false;
         A361DespBodCatId = obj86.gxTpr_Despbodcatid;
         n361DespBodCatId = false;
         A362DespBodDif = obj86.gxTpr_Despboddif;
         A1EmpID = obj86.gxTpr_Empid;
         A2AgeID = obj86.gxTpr_Ageid;
         A353DespBodNro = obj86.gxTpr_Despbodnro;
         A354DespBodOpId = obj86.gxTpr_Despbodopid;
         Z1EmpID = obj86.gxTpr_Empid_Z;
         Z44empdsc = obj86.gxTpr_Empdsc_Z;
         Z2AgeID = obj86.gxTpr_Ageid_Z;
         Z46AgeDsc = obj86.gxTpr_Agedsc_Z;
         Z42BodCod = obj86.gxTpr_Bodcod_Z;
         Z217BodDsc = obj86.gxTpr_Boddsc_Z;
         Z353DespBodNro = obj86.gxTpr_Despbodnro_Z;
         Z354DespBodOpId = obj86.gxTpr_Despbodopid_Z;
         Z355DespBodCodPrd = obj86.gxTpr_Despbodcodprd_Z;
         Z356DespBodPrdNombre = obj86.gxTpr_Despbodprdnombre_Z;
         Z357DespBodCant = obj86.gxTpr_Despbodcant_Z;
         Z358DespBodValor = obj86.gxTpr_Despbodvalor_Z;
         Z359DespBodADesp = obj86.gxTpr_Despbodadesp_Z;
         Z360DespBodStock = obj86.gxTpr_Despbodstock_Z;
         Z361DespBodCatId = obj86.gxTpr_Despbodcatid_Z;
         Z362DespBodDif = obj86.gxTpr_Despboddif_Z;
         n44empdsc = (bool)(Convert.ToBoolean(obj86.gxTpr_Empdsc_N));
         n46AgeDsc = (bool)(Convert.ToBoolean(obj86.gxTpr_Agedsc_N));
         n217BodDsc = (bool)(Convert.ToBoolean(obj86.gxTpr_Boddsc_N));
         n355DespBodCodPrd = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodcodprd_N));
         n356DespBodPrdNombre = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodprdnombre_N));
         n357DespBodCant = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodcant_N));
         n358DespBodValor = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodvalor_N));
         n359DespBodADesp = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodadesp_N));
         n361DespBodCatId = (bool)(Convert.ToBoolean(obj86.gxTpr_Despbodcatid_N));
         Gx_mode = obj86.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1EmpID = (short)getParm(obj,0);
         A2AgeID = (short)getParm(obj,1);
         A353DespBodNro = (short)getParm(obj,2);
         A354DespBodOpId = (short)getParm(obj,3);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1286( ) ;
         ScanKeyStart1286( ) ;
         if ( RcdFound86 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001212 */
            pr_default.execute(10, new Object[] {A1EmpID});
            if ( (pr_default.getStatus(10) == 101) )
            {
               GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
               AnyError = 1;
            }
            A44empdsc = BC001212_A44empdsc[0];
            n44empdsc = BC001212_n44empdsc[0];
            pr_default.close(10);
            /* Using cursor BC001213 */
            pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
            if ( (pr_default.getStatus(11) == 101) )
            {
               GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
               AnyError = 1;
            }
            A46AgeDsc = BC001213_A46AgeDsc[0];
            n46AgeDsc = BC001213_n46AgeDsc[0];
            pr_default.close(11);
         }
         else
         {
            Gx_mode = "UPD";
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z354DespBodOpId = A354DespBodOpId;
         }
         ZM1286( -3) ;
         OnLoadActions1286( ) ;
         AddRow1286( ) ;
         ScanKeyEnd1286( ) ;
         if ( RcdFound86 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars86( bcDespBodega, 0) ;
         ScanKeyStart1286( ) ;
         if ( RcdFound86 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001212 */
            pr_default.execute(10, new Object[] {A1EmpID});
            if ( (pr_default.getStatus(10) == 101) )
            {
               GX_msglist.addItem("No existe 'Empresas'.", "ForeignKeyNotFound", 1, "EMPID");
               AnyError = 1;
            }
            A44empdsc = BC001212_A44empdsc[0];
            n44empdsc = BC001212_n44empdsc[0];
            pr_default.close(10);
            /* Using cursor BC001213 */
            pr_default.execute(11, new Object[] {A1EmpID, A2AgeID});
            if ( (pr_default.getStatus(11) == 101) )
            {
               GX_msglist.addItem("No existe 'Agencias'.", "ForeignKeyNotFound", 1, "EMPID");
               AnyError = 1;
            }
            A46AgeDsc = BC001213_A46AgeDsc[0];
            n46AgeDsc = BC001213_n46AgeDsc[0];
            pr_default.close(11);
         }
         else
         {
            Gx_mode = "UPD";
            Z1EmpID = A1EmpID;
            Z2AgeID = A2AgeID;
            Z353DespBodNro = A353DespBodNro;
            Z354DespBodOpId = A354DespBodOpId;
         }
         ZM1286( -3) ;
         OnLoadActions1286( ) ;
         AddRow1286( ) ;
         ScanKeyEnd1286( ) ;
         if ( RcdFound86 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1286( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1286( ) ;
         }
         else
         {
            if ( RcdFound86 == 1 )
            {
               if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A354DespBodOpId != Z354DespBodOpId ) )
               {
                  A1EmpID = Z1EmpID;
                  A2AgeID = Z2AgeID;
                  A353DespBodNro = Z353DespBodNro;
                  A354DespBodOpId = Z354DespBodOpId;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update1286( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A354DespBodOpId != Z354DespBodOpId ) )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert1286( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert1286( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars86( bcDespBodega, 0) ;
         SaveImpl( ) ;
         VarsToRow86( bcDespBodega) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars86( bcDespBodega, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1286( ) ;
         AfterTrn( ) ;
         VarsToRow86( bcDespBodega) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtDespBodega auxBC = new SdtDespBodega(context) ;
            auxBC.Load(A1EmpID, A2AgeID, A353DespBodNro, A354DespBodOpId);
            auxBC.UpdateDirties(bcDespBodega);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars86( bcDespBodega, 0) ;
         UpdateImpl( ) ;
         VarsToRow86( bcDespBodega) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars86( bcDespBodega, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1286( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow86( bcDespBodega) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars86( bcDespBodega, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1286( ) ;
         if ( RcdFound86 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A354DespBodOpId != Z354DespBodOpId ) )
            {
               A1EmpID = Z1EmpID;
               A2AgeID = Z2AgeID;
               A353DespBodNro = Z353DespBodNro;
               A354DespBodOpId = Z354DespBodOpId;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( A1EmpID != Z1EmpID ) || ( A2AgeID != Z2AgeID ) || ( A353DespBodNro != Z353DespBodNro ) || ( A354DespBodOpId != Z354DespBodOpId ) )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(10);
         pr_default.close(11);
         pr_default.close(12);
         context.RollbackDataStores("despbodega_bc",pr_default);
         VarsToRow86( bcDespBodega) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcDespBodega.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcDespBodega.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcDespBodega )
         {
            bcDespBodega = (SdtDespBodega)(sdt);
            if ( StringUtil.StrCmp(bcDespBodega.gxTpr_Mode, "") == 0 )
            {
               bcDespBodega.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow86( bcDespBodega) ;
            }
            else
            {
               RowToVars86( bcDespBodega, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcDespBodega.gxTpr_Mode, "") == 0 )
            {
               bcDespBodega.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars86( bcDespBodega, 1) ;
         return  ;
      }

      public SdtDespBodega DespBodega_BC
      {
         get {
            return bcDespBodega ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
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
         pr_default.close(10);
         pr_default.close(11);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z356DespBodPrdNombre = "";
         A356DespBodPrdNombre = "";
         Z44empdsc = "";
         A44empdsc = "";
         Z46AgeDsc = "";
         A46AgeDsc = "";
         Z217BodDsc = "";
         A217BodDsc = "";
         BC00127_A353DespBodNro = new short[1] ;
         BC00127_A354DespBodOpId = new short[1] ;
         BC00127_A44empdsc = new String[] {""} ;
         BC00127_n44empdsc = new bool[] {false} ;
         BC00127_A46AgeDsc = new String[] {""} ;
         BC00127_n46AgeDsc = new bool[] {false} ;
         BC00127_A217BodDsc = new String[] {""} ;
         BC00127_n217BodDsc = new bool[] {false} ;
         BC00127_A355DespBodCodPrd = new short[1] ;
         BC00127_n355DespBodCodPrd = new bool[] {false} ;
         BC00127_A356DespBodPrdNombre = new String[] {""} ;
         BC00127_n356DespBodPrdNombre = new bool[] {false} ;
         BC00127_A357DespBodCant = new int[1] ;
         BC00127_n357DespBodCant = new bool[] {false} ;
         BC00127_A358DespBodValor = new decimal[1] ;
         BC00127_n358DespBodValor = new bool[] {false} ;
         BC00127_A359DespBodADesp = new int[1] ;
         BC00127_n359DespBodADesp = new bool[] {false} ;
         BC00127_A361DespBodCatId = new short[1] ;
         BC00127_n361DespBodCatId = new bool[] {false} ;
         BC00127_A1EmpID = new short[1] ;
         BC00127_A2AgeID = new short[1] ;
         BC00127_A42BodCod = new short[1] ;
         BC00124_A44empdsc = new String[] {""} ;
         BC00124_n44empdsc = new bool[] {false} ;
         BC00126_A217BodDsc = new String[] {""} ;
         BC00126_n217BodDsc = new bool[] {false} ;
         BC00125_A46AgeDsc = new String[] {""} ;
         BC00125_n46AgeDsc = new bool[] {false} ;
         BC00128_A1EmpID = new short[1] ;
         BC00128_A2AgeID = new short[1] ;
         BC00128_A353DespBodNro = new short[1] ;
         BC00128_A354DespBodOpId = new short[1] ;
         BC00123_A353DespBodNro = new short[1] ;
         BC00123_A354DespBodOpId = new short[1] ;
         BC00123_A355DespBodCodPrd = new short[1] ;
         BC00123_n355DespBodCodPrd = new bool[] {false} ;
         BC00123_A356DespBodPrdNombre = new String[] {""} ;
         BC00123_n356DespBodPrdNombre = new bool[] {false} ;
         BC00123_A357DespBodCant = new int[1] ;
         BC00123_n357DespBodCant = new bool[] {false} ;
         BC00123_A358DespBodValor = new decimal[1] ;
         BC00123_n358DespBodValor = new bool[] {false} ;
         BC00123_A359DespBodADesp = new int[1] ;
         BC00123_n359DespBodADesp = new bool[] {false} ;
         BC00123_A361DespBodCatId = new short[1] ;
         BC00123_n361DespBodCatId = new bool[] {false} ;
         BC00123_A1EmpID = new short[1] ;
         BC00123_A2AgeID = new short[1] ;
         BC00123_A42BodCod = new short[1] ;
         sMode86 = "";
         BC00122_A353DespBodNro = new short[1] ;
         BC00122_A354DespBodOpId = new short[1] ;
         BC00122_A355DespBodCodPrd = new short[1] ;
         BC00122_n355DespBodCodPrd = new bool[] {false} ;
         BC00122_A356DespBodPrdNombre = new String[] {""} ;
         BC00122_n356DespBodPrdNombre = new bool[] {false} ;
         BC00122_A357DespBodCant = new int[1] ;
         BC00122_n357DespBodCant = new bool[] {false} ;
         BC00122_A358DespBodValor = new decimal[1] ;
         BC00122_n358DespBodValor = new bool[] {false} ;
         BC00122_A359DespBodADesp = new int[1] ;
         BC00122_n359DespBodADesp = new bool[] {false} ;
         BC00122_A361DespBodCatId = new short[1] ;
         BC00122_n361DespBodCatId = new bool[] {false} ;
         BC00122_A1EmpID = new short[1] ;
         BC00122_A2AgeID = new short[1] ;
         BC00122_A42BodCod = new short[1] ;
         BC001212_A44empdsc = new String[] {""} ;
         BC001212_n44empdsc = new bool[] {false} ;
         BC001213_A46AgeDsc = new String[] {""} ;
         BC001213_n46AgeDsc = new bool[] {false} ;
         BC001214_A217BodDsc = new String[] {""} ;
         BC001214_n217BodDsc = new bool[] {false} ;
         BC001215_A353DespBodNro = new short[1] ;
         BC001215_A354DespBodOpId = new short[1] ;
         BC001215_A44empdsc = new String[] {""} ;
         BC001215_n44empdsc = new bool[] {false} ;
         BC001215_A46AgeDsc = new String[] {""} ;
         BC001215_n46AgeDsc = new bool[] {false} ;
         BC001215_A217BodDsc = new String[] {""} ;
         BC001215_n217BodDsc = new bool[] {false} ;
         BC001215_A355DespBodCodPrd = new short[1] ;
         BC001215_n355DespBodCodPrd = new bool[] {false} ;
         BC001215_A356DespBodPrdNombre = new String[] {""} ;
         BC001215_n356DespBodPrdNombre = new bool[] {false} ;
         BC001215_A357DespBodCant = new int[1] ;
         BC001215_n357DespBodCant = new bool[] {false} ;
         BC001215_A358DespBodValor = new decimal[1] ;
         BC001215_n358DespBodValor = new bool[] {false} ;
         BC001215_A359DespBodADesp = new int[1] ;
         BC001215_n359DespBodADesp = new bool[] {false} ;
         BC001215_A361DespBodCatId = new short[1] ;
         BC001215_n361DespBodCatId = new bool[] {false} ;
         BC001215_A1EmpID = new short[1] ;
         BC001215_A2AgeID = new short[1] ;
         BC001215_A42BodCod = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.despbodega_bc__default(),
            new Object[][] {
                new Object[] {
               BC00122_A353DespBodNro, BC00122_A354DespBodOpId, BC00122_A355DespBodCodPrd, BC00122_n355DespBodCodPrd, BC00122_A356DespBodPrdNombre, BC00122_n356DespBodPrdNombre, BC00122_A357DespBodCant, BC00122_n357DespBodCant, BC00122_A358DespBodValor, BC00122_n358DespBodValor,
               BC00122_A359DespBodADesp, BC00122_n359DespBodADesp, BC00122_A361DespBodCatId, BC00122_n361DespBodCatId, BC00122_A1EmpID, BC00122_A2AgeID, BC00122_A42BodCod
               }
               , new Object[] {
               BC00123_A353DespBodNro, BC00123_A354DespBodOpId, BC00123_A355DespBodCodPrd, BC00123_n355DespBodCodPrd, BC00123_A356DespBodPrdNombre, BC00123_n356DespBodPrdNombre, BC00123_A357DespBodCant, BC00123_n357DespBodCant, BC00123_A358DespBodValor, BC00123_n358DespBodValor,
               BC00123_A359DespBodADesp, BC00123_n359DespBodADesp, BC00123_A361DespBodCatId, BC00123_n361DespBodCatId, BC00123_A1EmpID, BC00123_A2AgeID, BC00123_A42BodCod
               }
               , new Object[] {
               BC00124_A44empdsc, BC00124_n44empdsc
               }
               , new Object[] {
               BC00125_A46AgeDsc, BC00125_n46AgeDsc
               }
               , new Object[] {
               BC00126_A217BodDsc, BC00126_n217BodDsc
               }
               , new Object[] {
               BC00127_A353DespBodNro, BC00127_A354DespBodOpId, BC00127_A44empdsc, BC00127_n44empdsc, BC00127_A46AgeDsc, BC00127_n46AgeDsc, BC00127_A217BodDsc, BC00127_n217BodDsc, BC00127_A355DespBodCodPrd, BC00127_n355DespBodCodPrd,
               BC00127_A356DespBodPrdNombre, BC00127_n356DespBodPrdNombre, BC00127_A357DespBodCant, BC00127_n357DespBodCant, BC00127_A358DespBodValor, BC00127_n358DespBodValor, BC00127_A359DespBodADesp, BC00127_n359DespBodADesp, BC00127_A361DespBodCatId, BC00127_n361DespBodCatId,
               BC00127_A1EmpID, BC00127_A2AgeID, BC00127_A42BodCod
               }
               , new Object[] {
               BC00128_A1EmpID, BC00128_A2AgeID, BC00128_A353DespBodNro, BC00128_A354DespBodOpId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001212_A44empdsc, BC001212_n44empdsc
               }
               , new Object[] {
               BC001213_A46AgeDsc, BC001213_n46AgeDsc
               }
               , new Object[] {
               BC001214_A217BodDsc, BC001214_n217BodDsc
               }
               , new Object[] {
               BC001215_A353DespBodNro, BC001215_A354DespBodOpId, BC001215_A44empdsc, BC001215_n44empdsc, BC001215_A46AgeDsc, BC001215_n46AgeDsc, BC001215_A217BodDsc, BC001215_n217BodDsc, BC001215_A355DespBodCodPrd, BC001215_n355DespBodCodPrd,
               BC001215_A356DespBodPrdNombre, BC001215_n356DespBodPrdNombre, BC001215_A357DespBodCant, BC001215_n357DespBodCant, BC001215_A358DespBodValor, BC001215_n358DespBodValor, BC001215_A359DespBodADesp, BC001215_n359DespBodADesp, BC001215_A361DespBodCatId, BC001215_n361DespBodCatId,
               BC001215_A1EmpID, BC001215_A2AgeID, BC001215_A42BodCod
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z1EmpID ;
      private short A1EmpID ;
      private short Z2AgeID ;
      private short A2AgeID ;
      private short Z353DespBodNro ;
      private short A353DespBodNro ;
      private short Z354DespBodOpId ;
      private short A354DespBodOpId ;
      private short GX_JID ;
      private short Z355DespBodCodPrd ;
      private short A355DespBodCodPrd ;
      private short Z361DespBodCatId ;
      private short A361DespBodCatId ;
      private short Z42BodCod ;
      private short A42BodCod ;
      private short Z362DespBodDif ;
      private short A362DespBodDif ;
      private short RcdFound86 ;
      private int trnEnded ;
      private int Z357DespBodCant ;
      private int A357DespBodCant ;
      private int Z359DespBodADesp ;
      private int A359DespBodADesp ;
      private decimal Z358DespBodValor ;
      private decimal A358DespBodValor ;
      private decimal Z360DespBodStock ;
      private decimal A360DespBodStock ;
      private decimal GXt_decimal1 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String Z356DespBodPrdNombre ;
      private String A356DespBodPrdNombre ;
      private String Z46AgeDsc ;
      private String A46AgeDsc ;
      private String Z217BodDsc ;
      private String A217BodDsc ;
      private String sMode86 ;
      private bool n44empdsc ;
      private bool n46AgeDsc ;
      private bool n217BodDsc ;
      private bool n355DespBodCodPrd ;
      private bool n356DespBodPrdNombre ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n359DespBodADesp ;
      private bool n361DespBodCatId ;
      private bool Gx_longc ;
      private String Z44empdsc ;
      private String A44empdsc ;
      private SdtDespBodega bcDespBodega ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00127_A353DespBodNro ;
      private short[] BC00127_A354DespBodOpId ;
      private String[] BC00127_A44empdsc ;
      private bool[] BC00127_n44empdsc ;
      private String[] BC00127_A46AgeDsc ;
      private bool[] BC00127_n46AgeDsc ;
      private String[] BC00127_A217BodDsc ;
      private bool[] BC00127_n217BodDsc ;
      private short[] BC00127_A355DespBodCodPrd ;
      private bool[] BC00127_n355DespBodCodPrd ;
      private String[] BC00127_A356DespBodPrdNombre ;
      private bool[] BC00127_n356DespBodPrdNombre ;
      private int[] BC00127_A357DespBodCant ;
      private bool[] BC00127_n357DespBodCant ;
      private decimal[] BC00127_A358DespBodValor ;
      private bool[] BC00127_n358DespBodValor ;
      private int[] BC00127_A359DespBodADesp ;
      private bool[] BC00127_n359DespBodADesp ;
      private short[] BC00127_A361DespBodCatId ;
      private bool[] BC00127_n361DespBodCatId ;
      private short[] BC00127_A1EmpID ;
      private short[] BC00127_A2AgeID ;
      private short[] BC00127_A42BodCod ;
      private String[] BC00124_A44empdsc ;
      private bool[] BC00124_n44empdsc ;
      private String[] BC00126_A217BodDsc ;
      private bool[] BC00126_n217BodDsc ;
      private String[] BC00125_A46AgeDsc ;
      private bool[] BC00125_n46AgeDsc ;
      private short[] BC00128_A1EmpID ;
      private short[] BC00128_A2AgeID ;
      private short[] BC00128_A353DespBodNro ;
      private short[] BC00128_A354DespBodOpId ;
      private short[] BC00123_A353DespBodNro ;
      private short[] BC00123_A354DespBodOpId ;
      private short[] BC00123_A355DespBodCodPrd ;
      private bool[] BC00123_n355DespBodCodPrd ;
      private String[] BC00123_A356DespBodPrdNombre ;
      private bool[] BC00123_n356DespBodPrdNombre ;
      private int[] BC00123_A357DespBodCant ;
      private bool[] BC00123_n357DespBodCant ;
      private decimal[] BC00123_A358DespBodValor ;
      private bool[] BC00123_n358DespBodValor ;
      private int[] BC00123_A359DespBodADesp ;
      private bool[] BC00123_n359DespBodADesp ;
      private short[] BC00123_A361DespBodCatId ;
      private bool[] BC00123_n361DespBodCatId ;
      private short[] BC00123_A1EmpID ;
      private short[] BC00123_A2AgeID ;
      private short[] BC00123_A42BodCod ;
      private short[] BC00122_A353DespBodNro ;
      private short[] BC00122_A354DespBodOpId ;
      private short[] BC00122_A355DespBodCodPrd ;
      private bool[] BC00122_n355DespBodCodPrd ;
      private String[] BC00122_A356DespBodPrdNombre ;
      private bool[] BC00122_n356DespBodPrdNombre ;
      private int[] BC00122_A357DespBodCant ;
      private bool[] BC00122_n357DespBodCant ;
      private decimal[] BC00122_A358DespBodValor ;
      private bool[] BC00122_n358DespBodValor ;
      private int[] BC00122_A359DespBodADesp ;
      private bool[] BC00122_n359DespBodADesp ;
      private short[] BC00122_A361DespBodCatId ;
      private bool[] BC00122_n361DespBodCatId ;
      private short[] BC00122_A1EmpID ;
      private short[] BC00122_A2AgeID ;
      private short[] BC00122_A42BodCod ;
      private String[] BC001212_A44empdsc ;
      private bool[] BC001212_n44empdsc ;
      private String[] BC001213_A46AgeDsc ;
      private bool[] BC001213_n46AgeDsc ;
      private String[] BC001214_A217BodDsc ;
      private bool[] BC001214_n217BodDsc ;
      private short[] BC001215_A353DespBodNro ;
      private short[] BC001215_A354DespBodOpId ;
      private String[] BC001215_A44empdsc ;
      private bool[] BC001215_n44empdsc ;
      private String[] BC001215_A46AgeDsc ;
      private bool[] BC001215_n46AgeDsc ;
      private String[] BC001215_A217BodDsc ;
      private bool[] BC001215_n217BodDsc ;
      private short[] BC001215_A355DespBodCodPrd ;
      private bool[] BC001215_n355DespBodCodPrd ;
      private String[] BC001215_A356DespBodPrdNombre ;
      private bool[] BC001215_n356DespBodPrdNombre ;
      private int[] BC001215_A357DespBodCant ;
      private bool[] BC001215_n357DespBodCant ;
      private decimal[] BC001215_A358DespBodValor ;
      private bool[] BC001215_n358DespBodValor ;
      private int[] BC001215_A359DespBodADesp ;
      private bool[] BC001215_n359DespBodADesp ;
      private short[] BC001215_A361DespBodCatId ;
      private bool[] BC001215_n361DespBodCatId ;
      private short[] BC001215_A1EmpID ;
      private short[] BC001215_A2AgeID ;
      private short[] BC001215_A42BodCod ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class despbodega_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00127 ;
          prmBC00127 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00124 ;
          prmBC00124 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00126 ;
          prmBC00126 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00125 ;
          prmBC00125 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00128 ;
          prmBC00128 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00123 ;
          prmBC00123 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00122 ;
          prmBC00122 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00129 ;
          prmBC00129 = new Object[] {
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Int,6,0} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodADesp",SqlDbType.Int,8,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001210 ;
          prmBC001210 = new Object[] {
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Int,6,0} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodADesp",SqlDbType.Int,8,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001211 ;
          prmBC001211 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001214 ;
          prmBC001214 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001215 ;
          prmBC001215 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodOpId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001212 ;
          prmBC001212 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC001213 ;
          prmBC001213 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00122", "SELECT [DespBodNro], [DespBodOpId], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodCatId], [EmpID], [AgeID], [BodCod] FROM [DespBodega] WITH (UPDLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [DespBodOpId] = @DespBodOpId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00122,1,0,true,false )
             ,new CursorDef("BC00123", "SELECT [DespBodNro], [DespBodOpId], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodCatId], [EmpID], [AgeID], [BodCod] FROM [DespBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [DespBodOpId] = @DespBodOpId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00123,1,0,true,false )
             ,new CursorDef("BC00124", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00124,1,0,true,false )
             ,new CursorDef("BC00125", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00125,1,0,true,false )
             ,new CursorDef("BC00126", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00126,1,0,true,false )
             ,new CursorDef("BC00127", "SELECT TM1.[DespBodNro], TM1.[DespBodOpId], T2.[empdsc], T3.[AgeDsc], T4.[BodDsc], TM1.[DespBodCodPrd], TM1.[DespBodPrdNombre], TM1.[DespBodCant], TM1.[DespBodValor], TM1.[DespBodADesp], TM1.[DespBodCatId], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod] FROM ((([DespBodega] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Bodegas] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[BodCod] = TM1.[BodCod]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[DespBodNro] = @DespBodNro and TM1.[DespBodOpId] = @DespBodOpId ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[DespBodNro], TM1.[DespBodOpId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00127,100,0,true,false )
             ,new CursorDef("BC00128", "SELECT [EmpID], [AgeID], [DespBodNro], [DespBodOpId] FROM [DespBodega] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [DespBodOpId] = @DespBodOpId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00128,1,0,true,false )
             ,new CursorDef("BC00129", "INSERT INTO [DespBodega]([DespBodNro], [DespBodOpId], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodADesp], [DespBodCatId], [EmpID], [AgeID], [BodCod]) VALUES(@DespBodNro, @DespBodOpId, @DespBodCodPrd, @DespBodPrdNombre, @DespBodCant, @DespBodValor, @DespBodADesp, @DespBodCatId, @EmpID, @AgeID, @BodCod)", GxErrorMask.GX_NOMASK,prmBC00129)
             ,new CursorDef("BC001210", "UPDATE [DespBodega] SET [DespBodCodPrd]=@DespBodCodPrd, [DespBodPrdNombre]=@DespBodPrdNombre, [DespBodCant]=@DespBodCant, [DespBodValor]=@DespBodValor, [DespBodADesp]=@DespBodADesp, [DespBodCatId]=@DespBodCatId, [BodCod]=@BodCod  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [DespBodOpId] = @DespBodOpId", GxErrorMask.GX_NOMASK,prmBC001210)
             ,new CursorDef("BC001211", "DELETE FROM [DespBodega]  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [DespBodOpId] = @DespBodOpId", GxErrorMask.GX_NOMASK,prmBC001211)
             ,new CursorDef("BC001212", "SELECT [empdsc] FROM [Empresas] WITH (NOLOCK) WHERE [EmpID] = @EmpID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001212,1,0,true,false )
             ,new CursorDef("BC001213", "SELECT [AgeDsc] FROM [Agencias] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001213,1,0,true,false )
             ,new CursorDef("BC001214", "SELECT [BodDsc] FROM [Bodegas] WITH (NOLOCK) WHERE [EmpID] = @EmpID AND [BodCod] = @BodCod ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001214,1,0,true,false )
             ,new CursorDef("BC001215", "SELECT TM1.[DespBodNro], TM1.[DespBodOpId], T2.[empdsc], T3.[AgeDsc], T4.[BodDsc], TM1.[DespBodCodPrd], TM1.[DespBodPrdNombre], TM1.[DespBodCant], TM1.[DespBodValor], TM1.[DespBodADesp], TM1.[DespBodCatId], TM1.[EmpID], TM1.[AgeID], TM1.[BodCod] FROM ((([DespBodega] TM1 WITH (NOLOCK) INNER JOIN [Empresas] T2 WITH (NOLOCK) ON T2.[EmpID] = TM1.[EmpID]) INNER JOIN [Agencias] T3 WITH (NOLOCK) ON T3.[EmpID] = TM1.[EmpID] AND T3.[AgeID] = TM1.[AgeID]) INNER JOIN [Bodegas] T4 WITH (NOLOCK) ON T4.[EmpID] = TM1.[EmpID] AND T4.[BodCod] = TM1.[BodCod]) WHERE TM1.[EmpID] = @EmpID and TM1.[AgeID] = @AgeID and TM1.[DespBodNro] = @DespBodNro and TM1.[DespBodOpId] = @DespBodOpId ORDER BY TM1.[EmpID], TM1.[AgeID], TM1.[DespBodNro], TM1.[DespBodOpId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001215,100,0,true,false )
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
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((int[]) buf[6])[0] = rslt.getInt(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((short[]) buf[16])[0] = rslt.getShort(11) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 40) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((int[]) buf[6])[0] = rslt.getInt(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((short[]) buf[16])[0] = rslt.getShort(11) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                ((short[]) buf[20])[0] = rslt.getShort(12) ;
                ((short[]) buf[21])[0] = rslt.getShort(13) ;
                ((short[]) buf[22])[0] = rslt.getShort(14) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 40) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 40) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((short[]) buf[8])[0] = rslt.getShort(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getString(7, 40) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((short[]) buf[18])[0] = rslt.getShort(11) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                ((short[]) buf[20])[0] = rslt.getShort(12) ;
                ((short[]) buf[21])[0] = rslt.getShort(13) ;
                ((short[]) buf[22])[0] = rslt.getShort(14) ;
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
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 8 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(8, (short)parms[13]);
                }
                stmt.SetParameter(9, (short)parms[14]);
                stmt.SetParameter(10, (short)parms[15]);
                stmt.SetParameter(11, (short)parms[16]);
                return;
             case 8 :
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
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(3, (int)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (decimal)parms[7]);
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
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
       }
    }

 }

}
