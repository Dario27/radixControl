/*
               File: AddDespachoOP
        Description: Add Despacho OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/12/2023 23:4:33.36
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
   public class adddespachoop : GXProcedure
   {
      public adddespachoop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public adddespachoop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_BodCod ,
                           short aP3_DespBodOpId ,
                           short aP4_DespBodCodPrd ,
                           String aP5_DespBodPrdNombre ,
                           decimal aP6_DespBodCant ,
                           short aP7_DespBodCatId ,
                           decimal aP8_DespBodValor ,
                           String aP9_DespBodDetalle )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV10BodCod = aP2_BodCod;
         this.AV12DespBodOpId = aP3_DespBodOpId;
         this.AV16DespBodCodPrd = aP4_DespBodCodPrd;
         this.AV13DespBodPrdNombre = aP5_DespBodPrdNombre;
         this.AV14DespBodCant = aP6_DespBodCant;
         this.AV15DespBodCatId = aP7_DespBodCatId;
         this.AV18DespBodValor = aP8_DespBodValor;
         this.AV19DespBodDetalle = aP9_DespBodDetalle;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_BodCod ,
                                 short aP3_DespBodOpId ,
                                 short aP4_DespBodCodPrd ,
                                 String aP5_DespBodPrdNombre ,
                                 decimal aP6_DespBodCant ,
                                 short aP7_DespBodCatId ,
                                 decimal aP8_DespBodValor ,
                                 String aP9_DespBodDetalle )
      {
         adddespachoop objadddespachoop;
         objadddespachoop = new adddespachoop();
         objadddespachoop.AV8EmpID = aP0_EmpID;
         objadddespachoop.AV9AgeID = aP1_AgeID;
         objadddespachoop.AV10BodCod = aP2_BodCod;
         objadddespachoop.AV12DespBodOpId = aP3_DespBodOpId;
         objadddespachoop.AV16DespBodCodPrd = aP4_DespBodCodPrd;
         objadddespachoop.AV13DespBodPrdNombre = aP5_DespBodPrdNombre;
         objadddespachoop.AV14DespBodCant = aP6_DespBodCant;
         objadddespachoop.AV15DespBodCatId = aP7_DespBodCatId;
         objadddespachoop.AV18DespBodValor = aP8_DespBodValor;
         objadddespachoop.AV19DespBodDetalle = aP9_DespBodDetalle;
         objadddespachoop.context.SetSubmitInitialConfig(context);
         objadddespachoop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objadddespachoop);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((adddespachoop)stateInfo).executePrivate();
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
         this.cleanup();
      }

      public override void cleanup( )
      {
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV10BodCod ;
      private short AV12DespBodOpId ;
      private short AV16DespBodCodPrd ;
      private short AV15DespBodCatId ;
      private decimal AV14DespBodCant ;
      private decimal AV18DespBodValor ;
      private String AV13DespBodPrdNombre ;
      private String AV19DespBodDetalle ;
   }

}
