/*
               File: obtUltCodVehiculo
        Description: obt Ult Cod Vehiculo
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:9.64
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
   public class obtultcodvehiculo : GXProcedure
   {
      public obtultcodvehiculo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtultcodvehiculo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           out short aP1_ultimoNro )
      {
         this.AV8empID = aP0_empID;
         this.AV9ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultimoNro=this.AV9ultimoNro;
      }

      public short executeUdp( short aP0_empID )
      {
         this.AV8empID = aP0_empID;
         this.AV9ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultimoNro=this.AV9ultimoNro;
         return AV9ultimoNro ;
      }

      public void executeSubmit( short aP0_empID ,
                                 out short aP1_ultimoNro )
      {
         obtultcodvehiculo objobtultcodvehiculo;
         objobtultcodvehiculo = new obtultcodvehiculo();
         objobtultcodvehiculo.AV8empID = aP0_empID;
         objobtultcodvehiculo.AV9ultimoNro = 0 ;
         objobtultcodvehiculo.context.SetSubmitInitialConfig(context);
         objobtultcodvehiculo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtultcodvehiculo);
         aP1_ultimoNro=this.AV9ultimoNro;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtultcodvehiculo)stateInfo).executePrivate();
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
         AV9ultimoNro = 0;
         /* Using cursor P000D2 */
         pr_default.execute(0, new Object[] {AV8empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P000D2_A1EmpID[0];
            A71VehiculoCedResp = P000D2_A71VehiculoCedResp[0];
            n71VehiculoCedResp = P000D2_n71VehiculoCedResp[0];
            A8VehiculoID = P000D2_A8VehiculoID[0];
            AV10codVehiculo = A8VehiculoID;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9ultimoNro = (short)(AV10codVehiculo+1);
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
         scmdbuf = "";
         P000D2_A1EmpID = new short[1] ;
         P000D2_A71VehiculoCedResp = new String[] {""} ;
         P000D2_n71VehiculoCedResp = new bool[] {false} ;
         P000D2_A8VehiculoID = new short[1] ;
         A71VehiculoCedResp = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtultcodvehiculo__default(),
            new Object[][] {
                new Object[] {
               P000D2_A1EmpID, P000D2_A71VehiculoCedResp, P000D2_n71VehiculoCedResp, P000D2_A8VehiculoID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empID ;
      private short AV9ultimoNro ;
      private short A1EmpID ;
      private short A8VehiculoID ;
      private short AV10codVehiculo ;
      private String scmdbuf ;
      private String A71VehiculoCedResp ;
      private bool n71VehiculoCedResp ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000D2_A1EmpID ;
      private String[] P000D2_A71VehiculoCedResp ;
      private bool[] P000D2_n71VehiculoCedResp ;
      private short[] P000D2_A8VehiculoID ;
      private short aP1_ultimoNro ;
   }

   public class obtultcodvehiculo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          new Object[] {"@AV8empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D2", "SELECT [EmpID], [VehiculoCedResp], [VehiculoID] FROM [Vehiculos] WITH (NOLOCK) WHERE [EmpID] = @AV8empID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 13) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
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
                return;
       }
    }

 }

}
