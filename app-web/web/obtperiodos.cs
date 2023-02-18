/*
               File: ObtPeriodos
        Description: Obt Periodos
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:15.69
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
   public class obtperiodos : GXProcedure
   {
      public obtperiodos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtperiodos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           String aP1_procesoCod ,
                           DateTime aP2_fecha ,
                           out short aP3_mes )
      {
         this.A1EmpID = aP0_EmpID;
         this.A327procesoCod = aP1_procesoCod;
         this.AV9fecha = aP2_fecha;
         this.AV8mes = 0 ;
         initialize();
         executePrivate();
         aP3_mes=this.AV8mes;
      }

      public short executeUdp( short aP0_EmpID ,
                               String aP1_procesoCod ,
                               DateTime aP2_fecha )
      {
         this.A1EmpID = aP0_EmpID;
         this.A327procesoCod = aP1_procesoCod;
         this.AV9fecha = aP2_fecha;
         this.AV8mes = 0 ;
         initialize();
         executePrivate();
         aP3_mes=this.AV8mes;
         return AV8mes ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 String aP1_procesoCod ,
                                 DateTime aP2_fecha ,
                                 out short aP3_mes )
      {
         obtperiodos objobtperiodos;
         objobtperiodos = new obtperiodos();
         objobtperiodos.A1EmpID = aP0_EmpID;
         objobtperiodos.A327procesoCod = aP1_procesoCod;
         objobtperiodos.AV9fecha = aP2_fecha;
         objobtperiodos.AV8mes = 0 ;
         objobtperiodos.context.SetSubmitInitialConfig(context);
         objobtperiodos.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtperiodos);
         aP3_mes=this.AV8mes;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtperiodos)stateInfo).executePrivate();
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
         AV8mes = 0;
         /* Using cursor P00192 */
         pr_default.execute(0, new Object[] {A1EmpID, A327procesoCod, AV9fecha});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A337detFchIni = P00192_A337detFchIni[0];
            A338detMes = P00192_A338detMes[0];
            n338detMes = P00192_n338detMes[0];
            A335PerAnio = P00192_A335PerAnio[0];
            AV8mes = A338detMes;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         P00192_A1EmpID = new short[1] ;
         P00192_A327procesoCod = new String[] {""} ;
         P00192_A337detFchIni = new DateTime[] {DateTime.MinValue} ;
         P00192_A338detMes = new short[1] ;
         P00192_n338detMes = new bool[] {false} ;
         P00192_A335PerAnio = new short[1] ;
         A337detFchIni = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtperiodos__default(),
            new Object[][] {
                new Object[] {
               P00192_A1EmpID, P00192_A327procesoCod, P00192_A337detFchIni, P00192_A338detMes, P00192_n338detMes, P00192_A335PerAnio
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1EmpID ;
      private short AV8mes ;
      private short A338detMes ;
      private short A335PerAnio ;
      private String scmdbuf ;
      private DateTime AV9fecha ;
      private DateTime A337detFchIni ;
      private bool n338detMes ;
      private String A327procesoCod ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00192_A1EmpID ;
      private String[] P00192_A327procesoCod ;
      private DateTime[] P00192_A337detFchIni ;
      private short[] P00192_A338detMes ;
      private bool[] P00192_n338detMes ;
      private short[] P00192_A335PerAnio ;
      private short aP3_mes ;
   }

   public class obtperiodos__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00192 ;
          prmP00192 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9fecha",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00192", "SELECT TOP 1 [EmpID], [procesoCod], [detFchIni], [detMes], [PerAnio] FROM [PeriodosDetdetFch] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod and [detFchIni] <= @AV9fecha ORDER BY [EmpID], [procesoCod], [detFchIni] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00192,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                return;
       }
    }

 }

}
