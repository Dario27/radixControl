/*
               File: ObtAnio
        Description: Obt Anio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/7/2023 16:1:54.19
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
   public class obtanio : GXProcedure
   {
      public obtanio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtanio( IGxContext context )
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
                           out short aP3_anio )
      {
         this.A1EmpID = aP0_EmpID;
         this.A327procesoCod = aP1_procesoCod;
         this.AV9fecha = aP2_fecha;
         this.AV8anio = 0 ;
         initialize();
         executePrivate();
         aP3_anio=this.AV8anio;
      }

      public short executeUdp( short aP0_EmpID ,
                               String aP1_procesoCod ,
                               DateTime aP2_fecha )
      {
         this.A1EmpID = aP0_EmpID;
         this.A327procesoCod = aP1_procesoCod;
         this.AV9fecha = aP2_fecha;
         this.AV8anio = 0 ;
         initialize();
         executePrivate();
         aP3_anio=this.AV8anio;
         return AV8anio ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 String aP1_procesoCod ,
                                 DateTime aP2_fecha ,
                                 out short aP3_anio )
      {
         obtanio objobtanio;
         objobtanio = new obtanio();
         objobtanio.A1EmpID = aP0_EmpID;
         objobtanio.A327procesoCod = aP1_procesoCod;
         objobtanio.AV9fecha = aP2_fecha;
         objobtanio.AV8anio = 0 ;
         objobtanio.context.SetSubmitInitialConfig(context);
         objobtanio.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtanio);
         aP3_anio=this.AV8anio;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtanio)stateInfo).executePrivate();
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
         AV8anio = 0;
         /* Using cursor P00182 */
         pr_default.execute(0, new Object[] {A1EmpID, A327procesoCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A335PerAnio = P00182_A335PerAnio[0];
            AV8anio = A335PerAnio;
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
         P00182_A1EmpID = new short[1] ;
         P00182_A327procesoCod = new String[] {""} ;
         P00182_A335PerAnio = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtanio__default(),
            new Object[][] {
                new Object[] {
               P00182_A1EmpID, P00182_A327procesoCod, P00182_A335PerAnio
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1EmpID ;
      private short AV8anio ;
      private short A335PerAnio ;
      private String scmdbuf ;
      private DateTime AV9fecha ;
      private String A327procesoCod ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00182_A1EmpID ;
      private String[] P00182_A327procesoCod ;
      private short[] P00182_A335PerAnio ;
      private short aP3_anio ;
   }

   public class obtanio__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00182 ;
          prmP00182 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@procesoCod",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00182", "SELECT TOP 1 [EmpID], [procesoCod], [PerAnio] FROM [PeriodosPer] WITH (NOLOCK) WHERE [EmpID] = @EmpID and [procesoCod] = @procesoCod ORDER BY [EmpID], [procesoCod], [PerAnio] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00182,1,0,false,true )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                return;
       }
    }

 }

}
