/*
               File: TableId68UpdateReferentialIntegrity
        Description: Load referential integrity
             Author: GeneXus C# Generator version 15_0_11-124690
       Generated on: 9/11/2022 0:26:21.0
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class tableid68updatereferentialintegrity : GXProcedure
   {
      public tableid68updatereferentialintegrity( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public tableid68updatereferentialintegrity( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         tableid68updatereferentialintegrity objtableid68updatereferentialintegrity;
         objtableid68updatereferentialintegrity = new tableid68updatereferentialintegrity();
         objtableid68updatereferentialintegrity.context.SetSubmitInitialConfig(context);
         objtableid68updatereferentialintegrity.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objtableid68updatereferentialintegrity);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tableid68updatereferentialintegrity)stateInfo).executePrivate();
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
         /* Using cursor TABLEID68U2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A286PrdCod = TABLEID68U2_A286PrdCod[0];
            A2AgeID = TABLEID68U2_A2AgeID[0];
            A1EmpID = TABLEID68U2_A1EmpID[0];
            A32categID = TABLEID68U2_A32categID[0];
            /*
               INSERT RECORD ON TABLE ProdPrecio

            */
            W1EmpID = A1EmpID;
            W2AgeID = A2AgeID;
            W286PrdCod = A286PrdCod;
            A302fecha = context.localUtil.YMDToD( 1753, 1, 1);
            A303valAnt = 0;
            n303valAnt = false;
            n303valAnt = true;
            A304valoAct = 0;
            n304valoAct = false;
            n304valoAct = true;
            A3UsuCod = " ";
            /* Using cursor TABLEID68U3 */
            pr_default.execute(1, new Object[] {A1EmpID, A2AgeID, A302fecha, A286PrdCod, n303valAnt, A303valAnt, n304valoAct, A304valoAct, A3UsuCod});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("ProdPrecio") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            A1EmpID = W1EmpID;
            A2AgeID = W2AgeID;
            A286PrdCod = W286PrdCod;
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Using cursor TABLEID68U4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A286PrdCod = TABLEID68U4_A286PrdCod[0];
            A2AgeID = TABLEID68U4_A2AgeID[0];
            A1EmpID = TABLEID68U4_A1EmpID[0];
            A290stockAnio = TABLEID68U4_A290stockAnio[0];
            A291stockMes = TABLEID68U4_A291stockMes[0];
            A42BodCod = TABLEID68U4_A42BodCod[0];
            /*
               INSERT RECORD ON TABLE ProdPrecio

            */
            W1EmpID = A1EmpID;
            W2AgeID = A2AgeID;
            W286PrdCod = A286PrdCod;
            A302fecha = context.localUtil.YMDToD( 1753, 1, 1);
            A303valAnt = 0;
            n303valAnt = false;
            n303valAnt = true;
            A304valoAct = 0;
            n304valoAct = false;
            n304valoAct = true;
            A3UsuCod = " ";
            /* Using cursor TABLEID68U5 */
            pr_default.execute(3, new Object[] {A1EmpID, A2AgeID, A302fecha, A286PrdCod, n303valAnt, A303valAnt, n304valoAct, A304valoAct, A3UsuCod});
            pr_default.close(3);
            dsDefault.SmartCacheProvider.SetUpdated("ProdPrecio") ;
            if ( (pr_default.getStatus(3) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            A1EmpID = W1EmpID;
            A2AgeID = W2AgeID;
            A286PrdCod = W286PrdCod;
            /* End Insert */
            pr_default.readNext(2);
         }
         pr_default.close(2);
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
         TABLEID68U2_A286PrdCod = new short[1] ;
         TABLEID68U2_A2AgeID = new short[1] ;
         TABLEID68U2_A1EmpID = new short[1] ;
         TABLEID68U2_A32categID = new short[1] ;
         A302fecha = DateTime.MinValue;
         A3UsuCod = "";
         Gx_emsg = "";
         TABLEID68U4_A286PrdCod = new short[1] ;
         TABLEID68U4_A2AgeID = new short[1] ;
         TABLEID68U4_A1EmpID = new short[1] ;
         TABLEID68U4_A290stockAnio = new short[1] ;
         TABLEID68U4_A291stockMes = new short[1] ;
         TABLEID68U4_A42BodCod = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tableid68updatereferentialintegrity__default(),
            new Object[][] {
                new Object[] {
               TABLEID68U2_A286PrdCod, TABLEID68U2_A2AgeID, TABLEID68U2_A1EmpID, TABLEID68U2_A32categID
               }
               , new Object[] {
               }
               , new Object[] {
               TABLEID68U4_A286PrdCod, TABLEID68U4_A2AgeID, TABLEID68U4_A1EmpID, TABLEID68U4_A290stockAnio, TABLEID68U4_A291stockMes, TABLEID68U4_A42BodCod
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A286PrdCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A32categID ;
      private short W1EmpID ;
      private short W2AgeID ;
      private short W286PrdCod ;
      private short A290stockAnio ;
      private short A291stockMes ;
      private short A42BodCod ;
      private int GX_INS68 ;
      private decimal A303valAnt ;
      private decimal A304valoAct ;
      private String scmdbuf ;
      private String A3UsuCod ;
      private String Gx_emsg ;
      private DateTime A302fecha ;
      private bool n303valAnt ;
      private bool n304valoAct ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TABLEID68U2_A286PrdCod ;
      private short[] TABLEID68U2_A2AgeID ;
      private short[] TABLEID68U2_A1EmpID ;
      private short[] TABLEID68U2_A32categID ;
      private short[] TABLEID68U4_A286PrdCod ;
      private short[] TABLEID68U4_A2AgeID ;
      private short[] TABLEID68U4_A1EmpID ;
      private short[] TABLEID68U4_A290stockAnio ;
      private short[] TABLEID68U4_A291stockMes ;
      private short[] TABLEID68U4_A42BodCod ;
   }

   public class tableid68updatereferentialintegrity__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmTABLEID68U2 ;
          prmTABLEID68U2 = new Object[] {
          } ;
          Object[] prmTABLEID68U3 ;
          prmTABLEID68U3 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@valAnt",SqlDbType.Decimal,10,2} ,
          new Object[] {"@valoAct",SqlDbType.Decimal,10,2} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmTABLEID68U4 ;
          prmTABLEID68U4 = new Object[] {
          } ;
          Object[] prmTABLEID68U5 ;
          prmTABLEID68U5 = new Object[] {
          new Object[] {"@EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@fecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@valAnt",SqlDbType.Decimal,10,2} ,
          new Object[] {"@valoAct",SqlDbType.Decimal,10,2} ,
          new Object[] {"@UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TABLEID68U2", "SELECT [PrdCod], [AgeID], [EmpID], [categID] FROM [Productos] ORDER BY [EmpID], [AgeID], [PrdCod], [categID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTABLEID68U2,100,0,true,false )
             ,new CursorDef("TABLEID68U3", "INSERT INTO [ProdPrecio]([EmpID], [AgeID], [fecha], [PrdCod], [valAnt], [valoAct], [UsuCod]) VALUES(@EmpID, @AgeID, @fecha, @PrdCod, @valAnt, @valoAct, @UsuCod)", GxErrorMask.GX_NOMASK,prmTABLEID68U3)
             ,new CursorDef("TABLEID68U4", "SELECT [PrdCod], [AgeID], [EmpID], [stockAnio], [stockMes], [BodCod] FROM [ProdxBodega] ORDER BY [stockAnio], [stockMes], [EmpID], [AgeID], [PrdCod], [BodCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTABLEID68U4,100,0,true,false )
             ,new CursorDef("TABLEID68U5", "INSERT INTO [ProdPrecio]([EmpID], [AgeID], [fecha], [PrdCod], [valAnt], [valoAct], [UsuCod]) VALUES(@EmpID, @AgeID, @fecha, @PrdCod, @valAnt, @valoAct, @UsuCod)", GxErrorMask.GX_NOMASK,prmTABLEID68U5)
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
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[7]);
                }
                stmt.SetParameter(7, (String)parms[8]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[7]);
                }
                stmt.SetParameter(7, (String)parms[8]);
                return;
       }
    }

 }

}
