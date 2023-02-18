/*
               File: obtNextCod
        Description: obt Next Cod
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/25/2022 0:6:10.25
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
   public class obtnextcod : GXProcedure
   {
      public obtnextcod( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtnextcod( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EmpID ,
                           short aP1_AgeID ,
                           out short aP2_ingreBodNro1 )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV11ingreBodNro1 = 0 ;
         initialize();
         executePrivate();
         aP2_ingreBodNro1=this.AV11ingreBodNro1;
      }

      public short executeUdp( short aP0_EmpID ,
                               short aP1_AgeID )
      {
         this.AV8EmpID = aP0_EmpID;
         this.AV9AgeID = aP1_AgeID;
         this.AV11ingreBodNro1 = 0 ;
         initialize();
         executePrivate();
         aP2_ingreBodNro1=this.AV11ingreBodNro1;
         return AV11ingreBodNro1 ;
      }

      public void executeSubmit( short aP0_EmpID ,
                                 short aP1_AgeID ,
                                 out short aP2_ingreBodNro1 )
      {
         obtnextcod objobtnextcod;
         objobtnextcod = new obtnextcod();
         objobtnextcod.AV8EmpID = aP0_EmpID;
         objobtnextcod.AV9AgeID = aP1_AgeID;
         objobtnextcod.AV11ingreBodNro1 = 0 ;
         objobtnextcod.context.SetSubmitInitialConfig(context);
         objobtnextcod.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtnextcod);
         aP2_ingreBodNro1=this.AV11ingreBodNro1;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtnextcod)stateInfo).executePrivate();
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
         AV14GXLvl1 = 0;
         /* Using cursor P001D2 */
         pr_default.execute(0, new Object[] {AV8EmpID, AV9AgeID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2AgeID = P001D2_A2AgeID[0];
            A1EmpID = P001D2_A1EmpID[0];
            A364ingreBodNro = P001D2_A364ingreBodNro[0];
            AV14GXLvl1 = 1;
            AV10ingreBodNro = A364ingreBodNro;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV14GXLvl1 == 0 )
         {
            AV11ingreBodNro1 = 1;
         }
         AV11ingreBodNro1 = (short)(AV10ingreBodNro+1);
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
         P001D2_A2AgeID = new short[1] ;
         P001D2_A1EmpID = new short[1] ;
         P001D2_A364ingreBodNro = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtnextcod__default(),
            new Object[][] {
                new Object[] {
               P001D2_A2AgeID, P001D2_A1EmpID, P001D2_A364ingreBodNro
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8EmpID ;
      private short AV9AgeID ;
      private short AV11ingreBodNro1 ;
      private short AV14GXLvl1 ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A364ingreBodNro ;
      private short AV10ingreBodNro ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001D2_A2AgeID ;
      private short[] P001D2_A1EmpID ;
      private short[] P001D2_A364ingreBodNro ;
      private short aP2_ingreBodNro1 ;
   }

   public class obtnextcod__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001D2 ;
          prmP001D2 = new Object[] {
          new Object[] {"@AV8EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9AgeID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001D2", "SELECT TOP 1 [AgeID], [EmpID], [ingreBodNro] FROM [IngresoBodegas] WITH (NOLOCK) WHERE [EmpID] = @AV8EmpID and [AgeID] = @AV9AgeID ORDER BY [EmpID] DESC, [AgeID] DESC, [ingreBodNro] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D2,1,0,false,true )
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
