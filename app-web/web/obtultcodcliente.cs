/*
               File: obtUltCodCliente
        Description: obt Ult Cod Cliente
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:9.40
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
   public class obtultcodcliente : GXProcedure
   {
      public obtultcodcliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtultcodcliente( IGxContext context )
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
         this.AV9empID = aP0_empID;
         this.AV10ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultimoNro=this.AV10ultimoNro;
      }

      public short executeUdp( short aP0_empID )
      {
         this.AV9empID = aP0_empID;
         this.AV10ultimoNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultimoNro=this.AV10ultimoNro;
         return AV10ultimoNro ;
      }

      public void executeSubmit( short aP0_empID ,
                                 out short aP1_ultimoNro )
      {
         obtultcodcliente objobtultcodcliente;
         objobtultcodcliente = new obtultcodcliente();
         objobtultcodcliente.AV9empID = aP0_empID;
         objobtultcodcliente.AV10ultimoNro = 0 ;
         objobtultcodcliente.context.SetSubmitInitialConfig(context);
         objobtultcodcliente.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtultcodcliente);
         aP1_ultimoNro=this.AV10ultimoNro;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtultcodcliente)stateInfo).executePrivate();
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
         /* Using cursor P000C2 */
         pr_default.execute(0, new Object[] {AV9empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5ClienteID = P000C2_A5ClienteID[0];
            A1EmpID = P000C2_A1EmpID[0];
            A59ClienteEst = P000C2_A59ClienteEst[0];
            n59ClienteEst = P000C2_n59ClienteEst[0];
            AV8codigo = A5ClienteID;
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
         P000C2_A5ClienteID = new short[1] ;
         P000C2_A1EmpID = new short[1] ;
         P000C2_A59ClienteEst = new String[] {""} ;
         P000C2_n59ClienteEst = new bool[] {false} ;
         A59ClienteEst = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtultcodcliente__default(),
            new Object[][] {
                new Object[] {
               P000C2_A5ClienteID, P000C2_A1EmpID, P000C2_A59ClienteEst, P000C2_n59ClienteEst
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9empID ;
      private short AV10ultimoNro ;
      private short A5ClienteID ;
      private short A1EmpID ;
      private short AV8codigo ;
      private String scmdbuf ;
      private String A59ClienteEst ;
      private bool n59ClienteEst ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000C2_A5ClienteID ;
      private short[] P000C2_A1EmpID ;
      private String[] P000C2_A59ClienteEst ;
      private bool[] P000C2_n59ClienteEst ;
      private short aP1_ultimoNro ;
   }

   public class obtultcodcliente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000C2 ;
          prmP000C2 = new Object[] {
          new Object[] {"@AV9empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000C2", "SELECT [ClienteID], [EmpID], [ClienteEst] FROM [Clientes] WITH (NOLOCK) WHERE ([EmpID] = @AV9empID) AND ([ClienteID] <> 9999) ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C2,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
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
