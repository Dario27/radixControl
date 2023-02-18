/*
               File: obtUltCodOP
        Description: obt Ult Cod OP
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/14/2023 1:15:32.47
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
   public class obtultcodop : GXProcedure
   {
      public obtultcodop( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtultcodop( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           short aP1_OrdenAnio ,
                           out short aP2_ultimoNro )
      {
         this.AV9empID = aP0_empID;
         this.AV11OrdenAnio = aP1_OrdenAnio;
         this.AV10ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP2_ultimoNro=this.AV10ultimoNro;
      }

      public short executeUdp( short aP0_empID ,
                               short aP1_OrdenAnio )
      {
         this.AV9empID = aP0_empID;
         this.AV11OrdenAnio = aP1_OrdenAnio;
         this.AV10ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP2_ultimoNro=this.AV10ultimoNro;
         return AV10ultimoNro ;
      }

      public void executeSubmit( short aP0_empID ,
                                 short aP1_OrdenAnio ,
                                 out short aP2_ultimoNro )
      {
         obtultcodop objobtultcodop;
         objobtultcodop = new obtultcodop();
         objobtultcodop.AV9empID = aP0_empID;
         objobtultcodop.AV11OrdenAnio = aP1_OrdenAnio;
         objobtultcodop.AV10ultimoNro = 0 ;
         objobtultcodop.context.SetSubmitInitialConfig(context);
         objobtultcodop.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtultcodop);
         aP2_ultimoNro=this.AV10ultimoNro;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtultcodop)stateInfo).executePrivate();
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
         AV10ultimoNro = 0;
         /* Using cursor P000E2 */
         pr_default.execute(0, new Object[] {AV11OrdenAnio, AV9empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P000E2_A1EmpID[0];
            A25OrdenAnio = P000E2_A25OrdenAnio[0];
            A22OrdenID = P000E2_A22OrdenID[0];
            A119OrdenFch = P000E2_A119OrdenFch[0];
            n119OrdenFch = P000E2_n119OrdenFch[0];
            A5ClienteID = P000E2_A5ClienteID[0];
            A24OrdenPeriodo = P000E2_A24OrdenPeriodo[0];
            AV8codigo = A22OrdenID;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV10ultimoNro = (short)(AV8codigo+1);
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
         P000E2_A1EmpID = new short[1] ;
         P000E2_A25OrdenAnio = new short[1] ;
         P000E2_A22OrdenID = new short[1] ;
         P000E2_A119OrdenFch = new DateTime[] {DateTime.MinValue} ;
         P000E2_n119OrdenFch = new bool[] {false} ;
         P000E2_A5ClienteID = new short[1] ;
         P000E2_A24OrdenPeriodo = new short[1] ;
         A119OrdenFch = DateTime.MinValue;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtultcodop__default(),
            new Object[][] {
                new Object[] {
               P000E2_A1EmpID, P000E2_A25OrdenAnio, P000E2_A22OrdenID, P000E2_A119OrdenFch, P000E2_n119OrdenFch, P000E2_A5ClienteID, P000E2_A24OrdenPeriodo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV11OrdenAnio ;
      private short AV10ultimoNro ;
      private short A1EmpID ;
      private short A25OrdenAnio ;
      private short A22OrdenID ;
      private short A5ClienteID ;
      private short A24OrdenPeriodo ;
      private short AV8codigo ;
      private String scmdbuf ;
      private DateTime A119OrdenFch ;
      private bool n119OrdenFch ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000E2_A1EmpID ;
      private short[] P000E2_A25OrdenAnio ;
      private short[] P000E2_A22OrdenID ;
      private DateTime[] P000E2_A119OrdenFch ;
      private bool[] P000E2_n119OrdenFch ;
      private short[] P000E2_A5ClienteID ;
      private short[] P000E2_A24OrdenPeriodo ;
      private short aP2_ultimoNro ;
   }

   public class obtultcodop__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000E2 ;
          prmP000E2 = new Object[] {
          new Object[] {"@AV11OrdenAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000E2", "SELECT TOP 1 [EmpID], [OrdenAnio], [OrdenID], [OrdenFch], [ClienteID], [OrdenPeriodo] FROM [OrdenProduccion] WITH (NOLOCK) WHERE ([OrdenAnio] = @AV11OrdenAnio) AND ([OrdenID] <> 9999) AND ([EmpID] = @AV9empID) ORDER BY [OrdenAnio] DESC, [OrdenID] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000E2,1,0,false,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
