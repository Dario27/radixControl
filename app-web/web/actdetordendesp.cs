/*
               File: actDetOrdenDesp
        Description: act Det Orden Desp
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 2:21:18.96
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
   public class actdetordendesp : GXProcedure
   {
      public actdetordendesp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actdetordendesp( IGxContext context )
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
                           short aP2_OrdenAnio ,
                           short aP3_OrdenPeriodo ,
                           short aP4_OrdenID ,
                           short aP5_ordenDesp )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9ClienteID = aP1_ClienteID;
         this.AV10OrdenAnio = aP2_OrdenAnio;
         this.AV11OrdenPeriodo = aP3_OrdenPeriodo;
         this.AV12OrdenID = aP4_OrdenID;
         this.AV13ordenDesp = aP5_ordenDesp;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenAnio ,
                                 short aP3_OrdenPeriodo ,
                                 short aP4_OrdenID ,
                                 short aP5_ordenDesp )
      {
         actdetordendesp objactdetordendesp;
         objactdetordendesp = new actdetordendesp();
         objactdetordendesp.AV8EmpID = aP0_EmpID;
         objactdetordendesp.AV9ClienteID = aP1_ClienteID;
         objactdetordendesp.AV10OrdenAnio = aP2_OrdenAnio;
         objactdetordendesp.AV11OrdenPeriodo = aP3_OrdenPeriodo;
         objactdetordendesp.AV12OrdenID = aP4_OrdenID;
         objactdetordendesp.AV13ordenDesp = aP5_ordenDesp;
         objactdetordendesp.context.SetSubmitInitialConfig(context);
         objactdetordendesp.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objactdetordendesp);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((actdetordendesp)stateInfo).executePrivate();
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
         /* Using cursor P001M2 */
         pr_default.execute(0, new Object[] {n397OrdenDesp, AV13ordenDesp, AV8EmpID, AV9ClienteID, AV11OrdenPeriodo, AV10OrdenAnio, AV12OrdenID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccionOpItems") ;
         /* End optimized UPDATE. */
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("actdetordendesp",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actdetordendesp__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9ClienteID ;
      private short AV10OrdenAnio ;
      private short AV11OrdenPeriodo ;
      private short AV12OrdenID ;
      private short AV13ordenDesp ;
      private short A397OrdenDesp ;
      private bool n397OrdenDesp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class actdetordendesp__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001M2 ;
          prmP001M2 = new Object[] {
          new Object[] {"@OrdenDesp",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV10OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001M2", "UPDATE [OrdenProduccionOpItems] SET [OrdenDesp]=@OrdenDesp  WHERE ([EmpID] = @AV8EmpID and [ClienteID] = @AV9ClienteID and [OrdenPeriodo] = @AV11OrdenPeriodo and [OrdenAnio] = @AV10OrdenAnio and [OrdenID] = @AV12OrdenID) AND ([OrdenDesp] IS NULL or [OrdenDesp] = 0)", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001M2)
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
       }
    }

 }

}
