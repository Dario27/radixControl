/*
               File: CambEstadoDespBod
        Description: Camb Estado Desp Bod
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/22/2023 1:28:28.62
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
   public class cambestadodespbod : GXProcedure
   {
      public cambestadodespbod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public cambestadodespbod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empId ,
                           short aP1_ageID ,
                           short aP2_DespBodNro ,
                           short aP3_ClienteID ,
                           short aP4_OrdenId )
      {
         this.AV8empId = aP0_empId;
         this.AV9ageID = aP1_ageID;
         this.AV10DespBodNro = aP2_DespBodNro;
         this.AV11ClienteID = aP3_ClienteID;
         this.AV12OrdenId = aP4_OrdenId;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_empId ,
                                 short aP1_ageID ,
                                 short aP2_DespBodNro ,
                                 short aP3_ClienteID ,
                                 short aP4_OrdenId )
      {
         cambestadodespbod objcambestadodespbod;
         objcambestadodespbod = new cambestadodespbod();
         objcambestadodespbod.AV8empId = aP0_empId;
         objcambestadodespbod.AV9ageID = aP1_ageID;
         objcambestadodespbod.AV10DespBodNro = aP2_DespBodNro;
         objcambestadodespbod.AV11ClienteID = aP3_ClienteID;
         objcambestadodespbod.AV12OrdenId = aP4_OrdenId;
         objcambestadodespbod.context.SetSubmitInitialConfig(context);
         objcambestadodespbod.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objcambestadodespbod);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cambestadodespbod)stateInfo).executePrivate();
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
         /* Optimized UPDATE. */
         /* Using cursor P001U2 */
         pr_default.execute(0, new Object[] {AV8empId, AV9ageID, AV10DespBodNro, AV12OrdenId, AV11ClienteID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("DespBodega") ;
         /* End optimized UPDATE. */
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("cambestadodespbod",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cambestadodespbod__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empId ;
      private short AV9ageID ;
      private short AV10DespBodNro ;
      private short AV11ClienteID ;
      private short AV12OrdenId ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class cambestadodespbod__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001U2 ;
          prmP001U2 = new Object[] {
          new Object[] {"@AV8empId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ageID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10DespBodNro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11ClienteID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001U2", "UPDATE [DespBodega] SET [DespachadoOK]='S'  WHERE [EmpID] = @AV8empId and [AgeID] = @AV9ageID and [DespBodNro] = @AV10DespBodNro and [OrdenID] = @AV12OrdenId and [ClienteID] = @AV11ClienteID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001U2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
       }
    }

 }

}
