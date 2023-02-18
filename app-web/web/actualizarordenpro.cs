/*
               File: actualizarOrdenPro
        Description: actualizar Orden Pro
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:33.13
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
   public class actualizarordenpro : GXProcedure
   {
      public actualizarordenpro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actualizarordenpro( IGxContext context )
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
                           int aP5_OrdenPed )
      {
         this.A1EmpID = aP0_EmpID;
         this.A5ClienteID = aP1_ClienteID;
         this.A24OrdenPeriodo = aP2_OrdenPeriodo;
         this.A25OrdenAnio = aP3_OrdenAnio;
         this.A22OrdenID = aP4_OrdenID;
         this.AV8OrdenPed = aP5_OrdenPed;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_ClienteID ,
                                 short aP2_OrdenPeriodo ,
                                 short aP3_OrdenAnio ,
                                 short aP4_OrdenID ,
                                 int aP5_OrdenPed )
      {
         actualizarordenpro objactualizarordenpro;
         objactualizarordenpro = new actualizarordenpro();
         objactualizarordenpro.A1EmpID = aP0_EmpID;
         objactualizarordenpro.A5ClienteID = aP1_ClienteID;
         objactualizarordenpro.A24OrdenPeriodo = aP2_OrdenPeriodo;
         objactualizarordenpro.A25OrdenAnio = aP3_OrdenAnio;
         objactualizarordenpro.A22OrdenID = aP4_OrdenID;
         objactualizarordenpro.AV8OrdenPed = aP5_OrdenPed;
         objactualizarordenpro.context.SetSubmitInitialConfig(context);
         objactualizarordenpro.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objactualizarordenpro);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((actualizarordenpro)stateInfo).executePrivate();
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
         /* Using cursor P00102 */
         pr_default.execute(0, new Object[] {n203ordenNroPed, AV8OrdenPed, A1EmpID, A5ClienteID, A24OrdenPeriodo, A25OrdenAnio, A22OrdenID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("OrdenProduccion") ;
         /* End optimized UPDATE. */
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("actualizarordenpro",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actualizarordenpro__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1EmpID ;
      private short A5ClienteID ;
      private short A24OrdenPeriodo ;
      private short A25OrdenAnio ;
      private short A22OrdenID ;
      private int AV8OrdenPed ;
      private int A203ordenNroPed ;
      private bool n203ordenNroPed ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class actualizarordenpro__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00102 ;
          prmP00102 = new Object[] {
          new Object[] {"@ordenNroPed",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClienteID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenPeriodo",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@OrdenID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00102", "UPDATE [OrdenProduccion] SET [ordenNroPed]=@ordenNroPed  WHERE [EmpID] = @EmpID and [ClienteID] = @ClienteID and [OrdenPeriodo] = @OrdenPeriodo and [OrdenAnio] = @OrdenAnio and [OrdenID] = @OrdenID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00102)
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
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
