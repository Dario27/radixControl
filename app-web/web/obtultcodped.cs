/*
               File: obtUltCodPed
        Description: obt Ult Cod Ped
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:10.58
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
   public class obtultcodped : GXProcedure
   {
      public obtultcodped( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtultcodped( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           out short aP1_Id )
      {
         this.AV8empID = aP0_empID;
         this.AV9Id = 0 ;
         initialize();
         executePrivate();
         aP1_Id=this.AV9Id;
      }

      public short executeUdp( short aP0_empID )
      {
         this.AV8empID = aP0_empID;
         this.AV9Id = 0 ;
         initialize();
         executePrivate();
         aP1_Id=this.AV9Id;
         return AV9Id ;
      }

      public void executeSubmit( short aP0_empID ,
                                 out short aP1_Id )
      {
         obtultcodped objobtultcodped;
         objobtultcodped = new obtultcodped();
         objobtultcodped.AV8empID = aP0_empID;
         objobtultcodped.AV9Id = 0 ;
         objobtultcodped.context.SetSubmitInitialConfig(context);
         objobtultcodped.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtultcodped);
         aP1_Id=this.AV9Id;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtultcodped)stateInfo).executePrivate();
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
         AV9Id = 0;
         /* Using cursor P000Q2 */
         pr_default.execute(0, new Object[] {AV8empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P000Q2_A1EmpID[0];
            A207PedUltNro = P000Q2_A207PedUltNro[0];
            n207PedUltNro = P000Q2_n207PedUltNro[0];
            A39PedCod = P000Q2_A39PedCod[0];
            AV10codigo = A39PedCod;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9Id = (short)(AV10codigo+1);
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
         P000Q2_A1EmpID = new short[1] ;
         P000Q2_A207PedUltNro = new int[1] ;
         P000Q2_n207PedUltNro = new bool[] {false} ;
         P000Q2_A39PedCod = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtultcodped__default(),
            new Object[][] {
                new Object[] {
               P000Q2_A1EmpID, P000Q2_A207PedUltNro, P000Q2_n207PedUltNro, P000Q2_A39PedCod
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empID ;
      private short AV9Id ;
      private short A1EmpID ;
      private int A207PedUltNro ;
      private int A39PedCod ;
      private int AV10codigo ;
      private String scmdbuf ;
      private bool n207PedUltNro ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000Q2_A1EmpID ;
      private int[] P000Q2_A207PedUltNro ;
      private bool[] P000Q2_n207PedUltNro ;
      private int[] P000Q2_A39PedCod ;
      private short aP1_Id ;
   }

   public class obtultcodped__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000Q2 ;
          prmP000Q2 = new Object[] {
          new Object[] {"@AV8empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Q2", "SELECT TOP 1 [EmpID], [PedUltNro], [PedCod] FROM [OrdenPedido] WITH (NOLOCK) WHERE [EmpID] = @AV8empID ORDER BY [EmpID] DESC, [PedCod] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q2,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
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
