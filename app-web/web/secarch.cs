/*
               File: secArch
        Description: sec Arch
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/26/2022 20:13:10.8
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
   public class secarch : GXProcedure
   {
      public secarch( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public secarch( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_empID ,
                           out short aP1_ultNro )
      {
         this.AV8empID = aP0_empID;
         this.AV9ultNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultNro=this.AV9ultNro;
      }

      public short executeUdp( short aP0_empID )
      {
         this.AV8empID = aP0_empID;
         this.AV9ultNro = 0 ;
         initialize();
         executePrivate();
         aP1_ultNro=this.AV9ultNro;
         return AV9ultNro ;
      }

      public void executeSubmit( short aP0_empID ,
                                 out short aP1_ultNro )
      {
         secarch objsecarch;
         objsecarch = new secarch();
         objsecarch.AV8empID = aP0_empID;
         objsecarch.AV9ultNro = 0 ;
         objsecarch.context.SetSubmitInitialConfig(context);
         objsecarch.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecarch);
         aP1_ultNro=this.AV9ultNro;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secarch)stateInfo).executePrivate();
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
         AV9ultNro = 0;
         /* Using cursor P000H2 */
         pr_default.execute(0, new Object[] {AV8empID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1EmpID = P000H2_A1EmpID[0];
            A27ArchSec = P000H2_A27ArchSec[0];
            A22OrdenID = P000H2_A22OrdenID[0];
            A28ArchClienteID = P000H2_A28ArchClienteID[0];
            A134ArchUrl = P000H2_A134ArchUrl[0];
            n134ArchUrl = P000H2_n134ArchUrl[0];
            AV9ultNro = A27ArchSec;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9ultNro = (short)(AV9ultNro+1);
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
         P000H2_A1EmpID = new short[1] ;
         P000H2_A27ArchSec = new short[1] ;
         P000H2_A22OrdenID = new short[1] ;
         P000H2_A28ArchClienteID = new short[1] ;
         P000H2_A134ArchUrl = new String[] {""} ;
         P000H2_n134ArchUrl = new bool[] {false} ;
         A134ArchUrl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.secarch__default(),
            new Object[][] {
                new Object[] {
               P000H2_A1EmpID, P000H2_A27ArchSec, P000H2_A22OrdenID, P000H2_A28ArchClienteID, P000H2_A134ArchUrl, P000H2_n134ArchUrl
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8empID ;
      private short AV9ultNro ;
      private short A1EmpID ;
      private short A27ArchSec ;
      private short A22OrdenID ;
      private short A28ArchClienteID ;
      private String scmdbuf ;
      private bool n134ArchUrl ;
      private String A134ArchUrl ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000H2_A1EmpID ;
      private short[] P000H2_A27ArchSec ;
      private short[] P000H2_A22OrdenID ;
      private short[] P000H2_A28ArchClienteID ;
      private String[] P000H2_A134ArchUrl ;
      private bool[] P000H2_n134ArchUrl ;
      private short aP1_ultNro ;
   }

   public class secarch__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000H2 ;
          prmP000H2 = new Object[] {
          new Object[] {"@AV8empID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000H2", "SELECT [EmpID], [ArchSec], [OrdenID], [ArchClienteID], [ArchUrl] FROM [ArchivosOP] WITH (NOLOCK) WHERE [EmpID] = @AV8empID ORDER BY [EmpID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H2,100,0,false,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getBLOBFile(5, "pdf", "") ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
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
