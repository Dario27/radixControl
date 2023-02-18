/*
               File: pdfPrevOPItems
        Description: Stub for pdfPrevOPItems
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 2/14/2023 22:5:42.30
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
   public class pdfprevopitems : GXProcedure
   {
      public pdfprevopitems( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public pdfprevopitems( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_ClienteID ,
                           short aP2_OrdenPeriodo ,
                           short aP3_OrdenAnio ,
                           short aP4_OrdenID ,
                           String aP5_Usercod )
      {
         this.AV2EmpID = aP0_EmpID;
         this.AV3ClienteID = aP1_ClienteID;
         this.AV4OrdenPeriodo = aP2_OrdenPeriodo;
         this.AV5OrdenAnio = aP3_OrdenAnio;
         this.AV6OrdenID = aP4_OrdenID;
         this.AV7Usercod = aP5_Usercod;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenID ,
                                 String aP5_Usercod )
      {
         pdfprevopitems objpdfprevopitems;
         objpdfprevopitems = new pdfprevopitems();
         objpdfprevopitems.AV2EmpID = aP0_EmpID;
         objpdfprevopitems.AV3ClienteID = aP1_ClienteID;
         objpdfprevopitems.AV4OrdenPeriodo = aP2_OrdenPeriodo;
         objpdfprevopitems.AV5OrdenAnio = aP3_OrdenAnio;
         objpdfprevopitems.AV6OrdenID = aP4_OrdenID;
         objpdfprevopitems.AV7Usercod = aP5_Usercod;
         objpdfprevopitems.context.SetSubmitInitialConfig(context);
         objpdfprevopitems.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objpdfprevopitems);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pdfprevopitems)stateInfo).executePrivate();
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
         args = new Object[] {(short)AV2EmpID,(short)AV3ClienteID,(short)AV4OrdenPeriodo,(short)AV5OrdenAnio,(short)AV6OrdenID,(String)AV7Usercod} ;
         ClassLoader.Execute("apdfprevopitems","GeneXus.Programs","apdfprevopitems", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 6 ) )
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

      private short AV2EmpID ;
      private short AV3ClienteID ;
      private short AV4OrdenPeriodo ;
      private short AV5OrdenAnio ;
      private short AV6OrdenID ;
      private String AV7Usercod ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
   }

}
