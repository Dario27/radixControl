/*
               File: prcAddDespBodSDT
        Description: prc Add Desp Bod SDT
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/12/2023 22:59:55.54
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
   public class prcadddespbodsdt : GXProcedure
   {
      public prcadddespbodsdt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prcadddespbodsdt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           short aP2_DespBodOpId ,
                           short aP3_BodCod ,
                           GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> aP4_SDTOrdenItems )
      {
         this.AV15EmpID = aP0_EmpID;
         this.AV16AgeID = aP1_AgeID;
         this.AV20DespBodOpId = aP2_DespBodOpId;
         this.AV18BodCod = aP3_BodCod;
         this.AV8SDTOrdenItems = aP4_SDTOrdenItems;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 short aP2_DespBodOpId ,
                                 short aP3_BodCod ,
                                 GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> aP4_SDTOrdenItems )
      {
         prcadddespbodsdt objprcadddespbodsdt;
         objprcadddespbodsdt = new prcadddespbodsdt();
         objprcadddespbodsdt.AV15EmpID = aP0_EmpID;
         objprcadddespbodsdt.AV16AgeID = aP1_AgeID;
         objprcadddespbodsdt.AV20DespBodOpId = aP2_DespBodOpId;
         objprcadddespbodsdt.AV18BodCod = aP3_BodCod;
         objprcadddespbodsdt.AV8SDTOrdenItems = aP4_SDTOrdenItems;
         objprcadddespbodsdt.context.SetSubmitInitialConfig(context);
         objprcadddespbodsdt.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprcadddespbodsdt);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prcadddespbodsdt)stateInfo).executePrivate();
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

      private short AV15EmpID ;
      private short AV16AgeID ;
      private short AV20DespBodOpId ;
      private short AV18BodCod ;
      private GXBaseCollection<SdtSDTOrdenItems_SDTOrdenItemsItem> AV8SDTOrdenItems ;
   }

}
