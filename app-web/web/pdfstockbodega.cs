/*
               File: pdfStockBodega
        Description: Stub for pdfStockBodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 12/30/2022 10:49:13.84
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
using System.Web.Services.Protocols;
using System.Web.Services;
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
   public class pdfstockbodega : GXProcedure
   {
      public pdfstockbodega( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public pdfstockbodega( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( DateTime aP0_fdesde ,
                           DateTime aP1_fHasta ,
                           short aP2_EmpID ,
                           short aP3_AgeID ,
                           short aP4_BodCod ,
                           short aP5_prdCod ,
                           String aP6_usuCod )
      {
         this.AV2fdesde = aP0_fdesde;
         this.AV3fHasta = aP1_fHasta;
         this.AV4EmpID = aP2_EmpID;
         this.AV5AgeID = aP3_AgeID;
         this.AV6BodCod = aP4_BodCod;
         this.AV7prdCod = aP5_prdCod;
         this.AV8usuCod = aP6_usuCod;
         initialize();
         executePrivate();
      }

      public void executeSubmit( DateTime aP0_fdesde ,
                                 DateTime aP1_fHasta ,
                                 short aP2_EmpID ,
                                 short aP3_AgeID ,
                                 short aP4_BodCod ,
                                 short aP5_prdCod ,
                                 String aP6_usuCod )
      {
         pdfstockbodega objpdfstockbodega;
         objpdfstockbodega = new pdfstockbodega();
         objpdfstockbodega.AV2fdesde = aP0_fdesde;
         objpdfstockbodega.AV3fHasta = aP1_fHasta;
         objpdfstockbodega.AV4EmpID = aP2_EmpID;
         objpdfstockbodega.AV5AgeID = aP3_AgeID;
         objpdfstockbodega.AV6BodCod = aP4_BodCod;
         objpdfstockbodega.AV7prdCod = aP5_prdCod;
         objpdfstockbodega.AV8usuCod = aP6_usuCod;
         objpdfstockbodega.context.SetSubmitInitialConfig(context);
         objpdfstockbodega.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpdfstockbodega);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pdfstockbodega)stateInfo).executePrivate();
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
         args = new Object[] {(DateTime)AV2fdesde,(DateTime)AV3fHasta,(short)AV4EmpID,(short)AV5AgeID,(short)AV6BodCod,(short)AV7prdCod,(String)AV8usuCod} ;
         ClassLoader.Execute("apdfstockbodega","GeneXus.Programs","apdfstockbodega", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 7 ) )
         {
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV4EmpID ;
      private short AV5AgeID ;
      private short AV6BodCod ;
      private short AV7prdCod ;
      private String AV8usuCod ;
      private DateTime AV2fdesde ;
      private DateTime AV3fHasta ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
   }

}
