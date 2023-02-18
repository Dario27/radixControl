/*
               File: insDespBodegaOP
        Description: ins Desp Bodega OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/23/2023 0:54:1.3
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class insdespbodegaop : GXProcedure
   {
      public insdespbodegaop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public insdespbodegaop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_BodCod ,
                           short aP3_ClienteID ,
                           short aP4_OrdenAnio ,
                           short aP5_OrdenPeriodo ,
                           short aP6_OrdenID )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV14AgeID = aP1_AgeID;
         this.AV15BodCod = aP2_BodCod;
         this.AV9ClienteID = aP3_ClienteID;
         this.AV10OrdenAnio = aP4_OrdenAnio;
         this.AV11OrdenPeriodo = aP5_OrdenPeriodo;
         this.AV12OrdenID = aP6_OrdenID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_BodCod ,
                                 short aP3_ClienteID ,
                                 short aP4_OrdenAnio ,
                                 short aP5_OrdenPeriodo ,
                                 short aP6_OrdenID )
      {
         insdespbodegaop objinsdespbodegaop;
         objinsdespbodegaop = new insdespbodegaop();
         objinsdespbodegaop.AV8EmpID = aP0_EmpID;
         objinsdespbodegaop.AV14AgeID = aP1_AgeID;
         objinsdespbodegaop.AV15BodCod = aP2_BodCod;
         objinsdespbodegaop.AV9ClienteID = aP3_ClienteID;
         objinsdespbodegaop.AV10OrdenAnio = aP4_OrdenAnio;
         objinsdespbodegaop.AV11OrdenPeriodo = aP5_OrdenPeriodo;
         objinsdespbodegaop.AV12OrdenID = aP6_OrdenID;
         objinsdespbodegaop.context.SetSubmitInitialConfig(context);
         objinsdespbodegaop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objinsdespbodegaop);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((insdespbodegaop)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P001Q2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9ClienteID, AV11OrdenPeriodo, AV10OrdenAnio, AV12OrdenID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A22OrdenID = P001Q2_A22OrdenID[0];
            A25OrdenAnio = P001Q2_A25OrdenAnio[0];
            A24OrdenPeriodo = P001Q2_A24OrdenPeriodo[0];
            A5ClienteID = P001Q2_A5ClienteID[0];
            A1EmpID = P001Q2_A1EmpID[0];
            A115OrdenEst = P001Q2_A115OrdenEst[0];
            n115OrdenEst = P001Q2_n115OrdenEst[0];
            A401OrdenNroDesp = P001Q2_A401OrdenNroDesp[0];
            n401OrdenNroDesp = P001Q2_n401OrdenNroDesp[0];
            AV24nroDespBod = (short)(A401OrdenNroDesp);
            /* Execute user subroutine: 'INSERNEWCAB' */
            S111 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV23nroReg = 0;
            /* Using cursor P001Q3 */
            pr_default.execute(1, new Object[] {A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A33subCatID = P001Q3_A33subCatID[0];
               A397OrdenDesp = P001Q3_A397OrdenDesp[0];
               n397OrdenDesp = P001Q3_n397OrdenDesp[0];
               A148subCatDsc = P001Q3_A148subCatDsc[0];
               n148subCatDsc = P001Q3_n148subCatDsc[0];
               A251OrdenDetDetalle = P001Q3_A251OrdenDetDetalle[0];
               n251OrdenDetDetalle = P001Q3_n251OrdenDetDetalle[0];
               A32categID = P001Q3_A32categID[0];
               A150subCatPrec = P001Q3_A150subCatPrec[0];
               n150subCatPrec = P001Q3_n150subCatPrec[0];
               A208OrdenDetCant = P001Q3_A208OrdenDetCant[0];
               n208OrdenDetCant = P001Q3_n208OrdenDetCant[0];
               A41OrdenSecId = P001Q3_A41OrdenSecId[0];
               A148subCatDsc = P001Q3_A148subCatDsc[0];
               n148subCatDsc = P001Q3_n148subCatDsc[0];
               A150subCatPrec = P001Q3_A150subCatPrec[0];
               n150subCatPrec = P001Q3_n150subCatPrec[0];
               A209OrdenDetVal = (decimal)(A150subCatPrec*A208OrdenDetCant);
               AV17prdDsc = A148subCatDsc;
               /* Execute user subroutine: 'BUSPRDCOD' */
               S151 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  this.cleanup();
                  if (true) return;
               }
               AV19despValor = A209OrdenDetVal;
               AV18despCantidad = A208OrdenDetCant;
               AV20despDetalle = A251OrdenDetDetalle;
               AV25DespBodCatId = A32categID;
               AV23nroReg = (int)(AV23nroReg+1);
               /* Execute user subroutine: 'INSERT' */
               S131 ();
               if ( returnInSub )
               {
                  pr_default.close(1);
                  this.cleanup();
                  if (true) return;
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'INSERNEWCAB' Routine */
         AV30GXLvl29 = 0;
         /* Using cursor P001Q4 */
         pr_default.execute(2, new Object[] {AV8EmpID, AV14AgeID, AV24nroDespBod, AV12OrdenID, AV9ClienteID, AV15BodCod});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A353DespBodNro = P001Q4_A353DespBodNro[0];
            A5ClienteID = P001Q4_A5ClienteID[0];
            A22OrdenID = P001Q4_A22OrdenID[0];
            A42BodCod = P001Q4_A42BodCod[0];
            A2AgeID = P001Q4_A2AgeID[0];
            A1EmpID = P001Q4_A1EmpID[0];
            A399DespBodUltReg = P001Q4_A399DespBodUltReg[0];
            n399DespBodUltReg = P001Q4_n399DespBodUltReg[0];
            AV30GXLvl29 = 1;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
         if ( AV30GXLvl29 == 0 )
         {
            /* Execute user subroutine: 'NEWID' */
            S121 ();
            if (returnInSub) return;
            /*
               INSERT RECORD ON TABLE DespBodega

            */
            A1EmpID = AV8EmpID;
            A2AgeID = AV14AgeID;
            A42BodCod = AV15BodCod;
            A353DespBodNro = AV21DespBodNro;
            A22OrdenID = AV12OrdenID;
            A5ClienteID = AV9ClienteID;
            /* Using cursor P001Q5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A42BodCod});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
            if ( (pr_default.getStatus(3) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
         }
      }

      protected void S121( )
      {
         /* 'NEWID' Routine */
         AV22newID = 0;
         /* Using cursor P001Q6 */
         pr_default.execute(4, new Object[] {AV8EmpID, AV14AgeID, AV15BodCod, AV12OrdenID, AV9ClienteID});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A5ClienteID = P001Q6_A5ClienteID[0];
            A22OrdenID = P001Q6_A22OrdenID[0];
            A42BodCod = P001Q6_A42BodCod[0];
            A2AgeID = P001Q6_A2AgeID[0];
            A1EmpID = P001Q6_A1EmpID[0];
            A353DespBodNro = P001Q6_A353DespBodNro[0];
            AV22newID = A353DespBodNro;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(4);
         }
         pr_default.close(4);
         AV21DespBodNro = (short)(AV22newID+1);
      }

      protected void S131( )
      {
         /* 'INSERT' Routine */
         AV32GXLvl68 = 0;
         /* Using cursor P001Q7 */
         pr_default.execute(5, new Object[] {AV8EmpID, AV14AgeID, AV24nroDespBod, AV12OrdenID, AV9ClienteID, AV23nroReg, AV16DespBodCodPrd});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A400nroReg = P001Q7_A400nroReg[0];
            A5ClienteID = P001Q7_A5ClienteID[0];
            A355DespBodCodPrd = P001Q7_A355DespBodCodPrd[0];
            n355DespBodCodPrd = P001Q7_n355DespBodCodPrd[0];
            A353DespBodNro = P001Q7_A353DespBodNro[0];
            A22OrdenID = P001Q7_A22OrdenID[0];
            A2AgeID = P001Q7_A2AgeID[0];
            A1EmpID = P001Q7_A1EmpID[0];
            A357DespBodCant = P001Q7_A357DespBodCant[0];
            n357DespBodCant = P001Q7_n357DespBodCant[0];
            A358DespBodValor = P001Q7_A358DespBodValor[0];
            n358DespBodValor = P001Q7_n358DespBodValor[0];
            A376DespBodDetalle = P001Q7_A376DespBodDetalle[0];
            n376DespBodDetalle = P001Q7_n376DespBodDetalle[0];
            A361DespBodCatId = P001Q7_A361DespBodCatId[0];
            n361DespBodCatId = P001Q7_n361DespBodCatId[0];
            AV32GXLvl68 = 1;
            A357DespBodCant = AV18despCantidad;
            n357DespBodCant = false;
            A358DespBodValor = AV19despValor;
            n358DespBodValor = false;
            A376DespBodDetalle = AV20despDetalle;
            n376DespBodDetalle = false;
            A361DespBodCatId = AV25DespBodCatId;
            n361DespBodCatId = false;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            /* Using cursor P001Q8 */
            pr_default.execute(6, new Object[] {n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n376DespBodDetalle, A376DespBodDetalle, n361DespBodCatId, A361DespBodCatId, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
            pr_default.close(6);
            dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
            if (true) break;
            /* Using cursor P001Q9 */
            pr_default.execute(7, new Object[] {n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n376DespBodDetalle, A376DespBodDetalle, n361DespBodCatId, A361DespBodCatId, A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg});
            pr_default.close(7);
            dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(5);
         if ( AV32GXLvl68 == 0 )
         {
            /* Execute user subroutine: 'INSERNEWDETPRD' */
            S141 ();
            if (returnInSub) return;
         }
      }

      protected void S141( )
      {
         /* 'INSERNEWDETPRD' Routine */
         /*
            INSERT RECORD ON TABLE DespBodegaprd

         */
         A1EmpID = AV8EmpID;
         A2AgeID = AV14AgeID;
         A22OrdenID = AV12OrdenID;
         A353DespBodNro = AV24nroDespBod;
         A5ClienteID = AV9ClienteID;
         A400nroReg = AV23nroReg;
         A355DespBodCodPrd = AV16DespBodCodPrd;
         n355DespBodCodPrd = false;
         A356DespBodPrdNombre = AV17prdDsc;
         n356DespBodPrdNombre = false;
         A357DespBodCant = AV18despCantidad;
         n357DespBodCant = false;
         A358DespBodValor = AV19despValor;
         n358DespBodValor = false;
         A376DespBodDetalle = AV20despDetalle;
         n376DespBodDetalle = false;
         A361DespBodCatId = AV25DespBodCatId;
         n361DespBodCatId = false;
         /* Using cursor P001Q10 */
         pr_default.execute(8, new Object[] {A1EmpID, A2AgeID, A353DespBodNro, A22OrdenID, A5ClienteID, A400nroReg, n355DespBodCodPrd, A355DespBodCodPrd, n356DespBodPrdNombre, A356DespBodPrdNombre, n357DespBodCant, A357DespBodCant, n358DespBodValor, A358DespBodValor, n376DespBodDetalle, A376DespBodDetalle, n361DespBodCatId, A361DespBodCatId});
         pr_default.close(8);
         dsDefault.SmartCacheProvider.SetUpdated("DespBodegaprd") ;
         if ( (pr_default.getStatus(8) == 1) )
         {
            context.Gx_err = 1;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", ""));
         }
         else
         {
            context.Gx_err = 0;
            Gx_emsg = "";
         }
         /* End Insert */
      }

      protected void S151( )
      {
         /* 'BUSPRDCOD' Routine */
         /* Using cursor P001Q11 */
         pr_default.execute(9, new Object[] {AV8EmpID, AV14AgeID, AV17prdDsc});
         while ( (pr_default.getStatus(9) != 101) )
         {
            A309prdNombre = P001Q11_A309prdNombre[0];
            n309prdNombre = P001Q11_n309prdNombre[0];
            A2AgeID = P001Q11_A2AgeID[0];
            A1EmpID = P001Q11_A1EmpID[0];
            A286PrdCod = P001Q11_A286PrdCod[0];
            AV16DespBodCodPrd = A286PrdCod;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(9);
         }
         pr_default.close(9);
      }

      public override void cleanup( )
      {
         context.CommitDataStores("insdespbodegaop",pr_default);
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P001Q2_A22OrdenID = new short[1] ;
         P001Q2_A25OrdenAnio = new short[1] ;
         P001Q2_A24OrdenPeriodo = new short[1] ;
         P001Q2_A5ClienteID = new short[1] ;
         P001Q2_A1EmpID = new short[1] ;
         P001Q2_A115OrdenEst = new String[] {""} ;
         P001Q2_n115OrdenEst = new bool[] {false} ;
         P001Q2_A401OrdenNroDesp = new int[1] ;
         P001Q2_n401OrdenNroDesp = new bool[] {false} ;
         A115OrdenEst = "";
         P001Q3_A33subCatID = new short[1] ;
         P001Q3_A1EmpID = new short[1] ;
         P001Q3_A5ClienteID = new short[1] ;
         P001Q3_A24OrdenPeriodo = new short[1] ;
         P001Q3_A25OrdenAnio = new short[1] ;
         P001Q3_A22OrdenID = new short[1] ;
         P001Q3_A397OrdenDesp = new short[1] ;
         P001Q3_n397OrdenDesp = new bool[] {false} ;
         P001Q3_A148subCatDsc = new String[] {""} ;
         P001Q3_n148subCatDsc = new bool[] {false} ;
         P001Q3_A251OrdenDetDetalle = new String[] {""} ;
         P001Q3_n251OrdenDetDetalle = new bool[] {false} ;
         P001Q3_A32categID = new short[1] ;
         P001Q3_A150subCatPrec = new decimal[1] ;
         P001Q3_n150subCatPrec = new bool[] {false} ;
         P001Q3_A208OrdenDetCant = new decimal[1] ;
         P001Q3_n208OrdenDetCant = new bool[] {false} ;
         P001Q3_A41OrdenSecId = new short[1] ;
         A148subCatDsc = "";
         A251OrdenDetDetalle = "";
         AV17prdDsc = "";
         AV20despDetalle = "";
         P001Q4_A353DespBodNro = new short[1] ;
         P001Q4_A5ClienteID = new short[1] ;
         P001Q4_A22OrdenID = new short[1] ;
         P001Q4_A42BodCod = new short[1] ;
         P001Q4_A2AgeID = new short[1] ;
         P001Q4_A1EmpID = new short[1] ;
         P001Q4_A399DespBodUltReg = new int[1] ;
         P001Q4_n399DespBodUltReg = new bool[] {false} ;
         Gx_emsg = "";
         P001Q6_A5ClienteID = new short[1] ;
         P001Q6_A22OrdenID = new short[1] ;
         P001Q6_A42BodCod = new short[1] ;
         P001Q6_A2AgeID = new short[1] ;
         P001Q6_A1EmpID = new short[1] ;
         P001Q6_A353DespBodNro = new short[1] ;
         P001Q7_A400nroReg = new int[1] ;
         P001Q7_A5ClienteID = new short[1] ;
         P001Q7_A355DespBodCodPrd = new short[1] ;
         P001Q7_n355DespBodCodPrd = new bool[] {false} ;
         P001Q7_A353DespBodNro = new short[1] ;
         P001Q7_A22OrdenID = new short[1] ;
         P001Q7_A2AgeID = new short[1] ;
         P001Q7_A1EmpID = new short[1] ;
         P001Q7_A357DespBodCant = new decimal[1] ;
         P001Q7_n357DespBodCant = new bool[] {false} ;
         P001Q7_A358DespBodValor = new decimal[1] ;
         P001Q7_n358DespBodValor = new bool[] {false} ;
         P001Q7_A376DespBodDetalle = new String[] {""} ;
         P001Q7_n376DespBodDetalle = new bool[] {false} ;
         P001Q7_A361DespBodCatId = new short[1] ;
         P001Q7_n361DespBodCatId = new bool[] {false} ;
         A376DespBodDetalle = "";
         A356DespBodPrdNombre = "";
         P001Q11_A309prdNombre = new String[] {""} ;
         P001Q11_n309prdNombre = new bool[] {false} ;
         P001Q11_A2AgeID = new short[1] ;
         P001Q11_A1EmpID = new short[1] ;
         P001Q11_A286PrdCod = new short[1] ;
         A309prdNombre = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.insdespbodegaop__default(),
            new Object[][] {
                new Object[] {
               P001Q2_A22OrdenID, P001Q2_A25OrdenAnio, P001Q2_A24OrdenPeriodo, P001Q2_A5ClienteID, P001Q2_A1EmpID, P001Q2_A115OrdenEst, P001Q2_n115OrdenEst, P001Q2_A401OrdenNroDesp, P001Q2_n401OrdenNroDesp
               }
               , new Object[] {
               P001Q3_A33subCatID, P001Q3_A1EmpID, P001Q3_A5ClienteID, P001Q3_A24OrdenPeriodo, P001Q3_A25OrdenAnio, P001Q3_A22OrdenID, P001Q3_A397OrdenDesp, P001Q3_n397OrdenDesp, P001Q3_A148subCatDsc, P001Q3_n148subCatDsc,
               P001Q3_A251OrdenDetDetalle, P001Q3_n251OrdenDetDetalle, P001Q3_A32categID, P001Q3_A150subCatPrec, P001Q3_n150subCatPrec, P001Q3_A208OrdenDetCant, P001Q3_n208OrdenDetCant, P001Q3_A41OrdenSecId
               }
               , new Object[] {
               P001Q4_A353DespBodNro, P001Q4_A5ClienteID, P001Q4_A22OrdenID, P001Q4_A42BodCod, P001Q4_A2AgeID, P001Q4_A1EmpID, P001Q4_A399DespBodUltReg, P001Q4_n399DespBodUltReg
               }
               , new Object[] {
               }
               , new Object[] {
               P001Q6_A5ClienteID, P001Q6_A22OrdenID, P001Q6_A42BodCod, P001Q6_A2AgeID, P001Q6_A1EmpID, P001Q6_A353DespBodNro
               }
               , new Object[] {
               P001Q7_A400nroReg, P001Q7_A5ClienteID, P001Q7_A355DespBodCodPrd, P001Q7_n355DespBodCodPrd, P001Q7_A353DespBodNro, P001Q7_A22OrdenID, P001Q7_A2AgeID, P001Q7_A1EmpID, P001Q7_A357DespBodCant, P001Q7_n357DespBodCant,
               P001Q7_A358DespBodValor, P001Q7_n358DespBodValor, P001Q7_A376DespBodDetalle, P001Q7_n376DespBodDetalle, P001Q7_A361DespBodCatId, P001Q7_n361DespBodCatId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P001Q11_A309prdNombre, P001Q11_n309prdNombre, P001Q11_A2AgeID, P001Q11_A1EmpID, P001Q11_A286PrdCod
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV14AgeID ;
      private short AV15BodCod ;
      private short AV9ClienteID ;
      private short AV10OrdenAnio ;
      private short AV11OrdenPeriodo ;
      private short AV12OrdenID ;
      private short A22OrdenID ;
      private short A25OrdenAnio ;
      private short A24OrdenPeriodo ;
      private short A5ClienteID ;
      private short A1EmpID ;
      private short AV24nroDespBod ;
      private short A33subCatID ;
      private short A397OrdenDesp ;
      private short A32categID ;
      private short A41OrdenSecId ;
      private short AV25DespBodCatId ;
      private short AV30GXLvl29 ;
      private short A353DespBodNro ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short AV21DespBodNro ;
      private short AV22newID ;
      private short AV32GXLvl68 ;
      private short AV16DespBodCodPrd ;
      private short A355DespBodCodPrd ;
      private short A361DespBodCatId ;
      private short A286PrdCod ;
      private int A401OrdenNroDesp ;
      private int AV23nroReg ;
      private int A399DespBodUltReg ;
      private int GX_INS93 ;
      private int A400nroReg ;
      private int GX_INS94 ;
      private decimal A150subCatPrec ;
      private decimal A208OrdenDetCant ;
      private decimal A209OrdenDetVal ;
      private decimal AV19despValor ;
      private decimal AV18despCantidad ;
      private decimal A357DespBodCant ;
      private decimal A358DespBodValor ;
      private String scmdbuf ;
      private String A115OrdenEst ;
      private String A148subCatDsc ;
      private String Gx_emsg ;
      private String A376DespBodDetalle ;
      private String A356DespBodPrdNombre ;
      private bool n115OrdenEst ;
      private bool n401OrdenNroDesp ;
      private bool returnInSub ;
      private bool n397OrdenDesp ;
      private bool n148subCatDsc ;
      private bool n251OrdenDetDetalle ;
      private bool n150subCatPrec ;
      private bool n208OrdenDetCant ;
      private bool n399DespBodUltReg ;
      private bool n355DespBodCodPrd ;
      private bool n357DespBodCant ;
      private bool n358DespBodValor ;
      private bool n376DespBodDetalle ;
      private bool n361DespBodCatId ;
      private bool n356DespBodPrdNombre ;
      private bool n309prdNombre ;
      private String A251OrdenDetDetalle ;
      private String AV17prdDsc ;
      private String AV20despDetalle ;
      private String A309prdNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001Q2_A22OrdenID ;
      private short[] P001Q2_A25OrdenAnio ;
      private short[] P001Q2_A24OrdenPeriodo ;
      private short[] P001Q2_A5ClienteID ;
      private short[] P001Q2_A1EmpID ;
      private String[] P001Q2_A115OrdenEst ;
      private bool[] P001Q2_n115OrdenEst ;
      private int[] P001Q2_A401OrdenNroDesp ;
      private bool[] P001Q2_n401OrdenNroDesp ;
      private short[] P001Q3_A33subCatID ;
      private short[] P001Q3_A1EmpID ;
      private short[] P001Q3_A5ClienteID ;
      private short[] P001Q3_A24OrdenPeriodo ;
      private short[] P001Q3_A25OrdenAnio ;
      private short[] P001Q3_A22OrdenID ;
      private short[] P001Q3_A397OrdenDesp ;
      private bool[] P001Q3_n397OrdenDesp ;
      private String[] P001Q3_A148subCatDsc ;
      private bool[] P001Q3_n148subCatDsc ;
      private String[] P001Q3_A251OrdenDetDetalle ;
      private bool[] P001Q3_n251OrdenDetDetalle ;
      private short[] P001Q3_A32categID ;
      private decimal[] P001Q3_A150subCatPrec ;
      private bool[] P001Q3_n150subCatPrec ;
      private decimal[] P001Q3_A208OrdenDetCant ;
      private bool[] P001Q3_n208OrdenDetCant ;
      private short[] P001Q3_A41OrdenSecId ;
      private short[] P001Q4_A353DespBodNro ;
      private short[] P001Q4_A5ClienteID ;
      private short[] P001Q4_A22OrdenID ;
      private short[] P001Q4_A42BodCod ;
      private short[] P001Q4_A2AgeID ;
      private short[] P001Q4_A1EmpID ;
      private int[] P001Q4_A399DespBodUltReg ;
      private bool[] P001Q4_n399DespBodUltReg ;
      private short[] P001Q6_A5ClienteID ;
      private short[] P001Q6_A22OrdenID ;
      private short[] P001Q6_A42BodCod ;
      private short[] P001Q6_A2AgeID ;
      private short[] P001Q6_A1EmpID ;
      private short[] P001Q6_A353DespBodNro ;
      private int[] P001Q7_A400nroReg ;
      private short[] P001Q7_A5ClienteID ;
      private short[] P001Q7_A355DespBodCodPrd ;
      private bool[] P001Q7_n355DespBodCodPrd ;
      private short[] P001Q7_A353DespBodNro ;
      private short[] P001Q7_A22OrdenID ;
      private short[] P001Q7_A2AgeID ;
      private short[] P001Q7_A1EmpID ;
      private decimal[] P001Q7_A357DespBodCant ;
      private bool[] P001Q7_n357DespBodCant ;
      private decimal[] P001Q7_A358DespBodValor ;
      private bool[] P001Q7_n358DespBodValor ;
      private String[] P001Q7_A376DespBodDetalle ;
      private bool[] P001Q7_n376DespBodDetalle ;
      private short[] P001Q7_A361DespBodCatId ;
      private bool[] P001Q7_n361DespBodCatId ;
      private String[] P001Q11_A309prdNombre ;
      private bool[] P001Q11_n309prdNombre ;
      private short[] P001Q11_A2AgeID ;
      private short[] P001Q11_A1EmpID ;
      private short[] P001Q11_A286PrdCod ;
   }

   public class insdespbodegaop__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001Q2 ;
          prmP001Q2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q3 ;
          prmP001Q3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q4 ;
          prmP001Q4 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV24nroDespBod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q5 ;
          prmP001Q5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BodCod",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q6 ;
          prmP001Q6 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q7 ;
          prmP001Q7 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV24nroDespBod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV23nroReg",SqlDbType.Int,6,0} ,
          new Object[] {"@AV16DespBodCodPrd",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q8 ;
          prmP001Q8 = new Object[] {
          new Object[] {"@DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmP001Q9 ;
          prmP001Q9 = new Object[] {
          new Object[] {"@DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0}
          } ;
          Object[] prmP001Q10 ;
          prmP001Q10 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@nroReg",SqlDbType.Int,6,0} ,
          new Object[] {"@DespBodCodPrd",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DespBodPrdNombre",SqlDbType.Char,40,0} ,
          new Object[] {"@DespBodCant",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodValor",SqlDbType.Decimal,8,2} ,
          new Object[] {"@DespBodDetalle",SqlDbType.Char,50,0} ,
          new Object[] {"@DespBodCatId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001Q11 ;
          prmP001Q11 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV17prdDsc",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001Q2", "SELECT [OrdenID], [OrdenAnio], [OrdenPeriodo], [ClienteID], [EmpID], [OrdenEst], [OrdenNroDesp] FROM [OrdenProduccion] WITH (NOLOCK) WHERE [EmpID] = @AV8EmpID and [ClienteID] = @AV9ClienteID and [OrdenPeriodo] = @AV11OrdenPeriodo and [OrdenAnio] = @AV10OrdenAnio and [OrdenID] = @AV12OrdenID ORDER BY [EmpID], [ClienteID], [OrdenPeriodo], [OrdenAnio], [OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q2,1,0,true,true )
             ,new CursorDef("P001Q3", "SELECT T1.[subCatID], T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID], T1.[OrdenDesp], T2.[subCatDsc], T1.[OrdenDetDetalle], T1.[categID], T2.[subCatPrec], T1.[OrdenDetCant], T1.[OrdenSecId] FROM ([OrdenProduccionOpItems] T1 WITH (NOLOCK) INNER JOIN [CategoriassubCat] T2 WITH (NOLOCK) ON T2.[EmpID] = T1.[EmpID] AND T2.[categID] = T1.[categID] AND T2.[subCatID] = T1.[subCatID]) WHERE (T1.[EmpID] = @EmpID and T1.[ClienteID] = @ClienteID and T1.[OrdenPeriodo] = @OrdenPeriodo and T1.[OrdenAnio] = @OrdenAnio and T1.[OrdenID] = @OrdenID) AND (T1.[OrdenDesp] IS NULL or T1.[OrdenDesp] = 0) ORDER BY T1.[EmpID], T1.[ClienteID], T1.[OrdenPeriodo], T1.[OrdenAnio], T1.[OrdenID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q3,100,0,true,false )
             ,new CursorDef("P001Q4", "SELECT TOP 1 [DespBodNro], [ClienteID], [OrdenID], [BodCod], [AgeID], [EmpID], [DespBodUltReg] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV14AgeID and [DespBodNro] = @AV24nroDespBod and [OrdenID] = @AV12OrdenID and [ClienteID] = @AV9ClienteID) AND ([BodCod] = @AV15BodCod) ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q4,1,0,false,true )
             ,new CursorDef("P001Q5", "INSERT INTO [DespBodega]([EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [BodCod], [DespBodUltReg], [DespachadoOK]) VALUES(@EmpID, @AgeID, @DespBodNro, @OrdenID, @ClienteID, @BodCod, convert(int, 0), '')", GxErrorMask.GX_NOMASK,prmP001Q5)
             ,new CursorDef("P001Q6", "SELECT TOP 1 [ClienteID], [OrdenID], [BodCod], [AgeID], [EmpID], [DespBodNro] FROM [DespBodega] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV14AgeID) AND ([BodCod] = @AV15BodCod) AND ([OrdenID] = @AV12OrdenID) AND ([ClienteID] = @AV9ClienteID) ORDER BY [EmpID] DESC, [AgeID] DESC, [DespBodNro] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q6,1,0,false,true )
             ,new CursorDef("P001Q7", "SELECT TOP 1 [nroReg], [ClienteID], [DespBodCodPrd], [DespBodNro], [OrdenID], [AgeID], [EmpID], [DespBodCant], [DespBodValor], [DespBodDetalle], [DespBodCatId] FROM [DespBodegaprd] WITH (UPDLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV14AgeID and [DespBodNro] = @AV24nroDespBod and [OrdenID] = @AV12OrdenID and [ClienteID] = @AV9ClienteID and [nroReg] = @AV23nroReg) AND ([DespBodCodPrd] = @AV16DespBodCodPrd) ORDER BY [EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q7,1,0,true,true )
             ,new CursorDef("P001Q8", "UPDATE [DespBodegaprd] SET [DespBodCant]=@DespBodCant, [DespBodValor]=@DespBodValor, [DespBodDetalle]=@DespBodDetalle, [DespBodCatId]=@DespBodCatId  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001Q8)
             ,new CursorDef("P001Q9", "UPDATE [DespBodegaprd] SET [DespBodCant]=@DespBodCant, [DespBodValor]=@DespBodValor, [DespBodDetalle]=@DespBodDetalle, [DespBodCatId]=@DespBodCatId  WHERE [EmpID] = @EmpID AND [AgeID] = @AgeID AND [DespBodNro] = @DespBodNro AND [OrdenID] = @OrdenID AND [ClienteID] = @ClienteID AND [nroReg] = @nroReg", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001Q9)
             ,new CursorDef("P001Q10", "INSERT INTO [DespBodegaprd]([EmpID], [AgeID], [DespBodNro], [OrdenID], [ClienteID], [nroReg], [DespBodCodPrd], [DespBodPrdNombre], [DespBodCant], [DespBodValor], [DespBodDetalle], [DespBodCatId], [DespBodADesp], [DespBodOK], [DespBodModifItem]) VALUES(@EmpID, @AgeID, @DespBodNro, @OrdenID, @ClienteID, @nroReg, @DespBodCodPrd, @DespBodPrdNombre, @DespBodCant, @DespBodValor, @DespBodDetalle, @DespBodCatId, convert(int, 0), '', '')", GxErrorMask.GX_NOMASK,prmP001Q10)
             ,new CursorDef("P001Q11", "SELECT TOP 1 [prdNombre], [AgeID], [EmpID], [PrdCod] FROM [Productos] WITH (NOLOCK) WHERE ([EmpID] = @AV8EmpID and [AgeID] = @AV14AgeID) AND ([prdNombre] = @AV17prdDsc) ORDER BY [EmpID], [AgeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q11,1,0,false,true )
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
                ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getString(8, 40) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((decimal[]) buf[13])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((decimal[]) buf[15])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((short[]) buf[17])[0] = rslt.getShort(13) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(11);
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 6 :
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
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
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
                stmt.SetParameter(10, (int)parms[13]);
                return;
             case 7 :
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
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
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
                stmt.SetParameter(10, (int)parms[13]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(7, (short)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 8 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 12 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(12, (short)parms[17]);
                }
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
