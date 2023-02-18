/*
               File: ProdxBodegaTipoConversion
        Description: Conversion for table ProdxBodegaTipo
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 10/28/2022 21:29:23.85
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
   public class prodxbodegatipoconversion : GXProcedure
   {
      public prodxbodegatipoconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public prodxbodegatipoconversion( IGxContext context )
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
         prodxbodegatipoconversion objprodxbodegatipoconversion;
         objprodxbodegatipoconversion = new prodxbodegatipoconversion();
         objprodxbodegatipoconversion.context.SetSubmitInitialConfig(context);
         objprodxbodegatipoconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objprodxbodegatipoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((prodxbodegatipoconversion)stateInfo).executePrivate();
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
         /* Using cursor PRODXBODEG2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A298costo = PRODXBODEG2_A298costo[0];
            n298costo = PRODXBODEG2_n298costo[0];
            A297stock = PRODXBODEG2_A297stock[0];
            n297stock = PRODXBODEG2_n297stock[0];
            A296cantidad = PRODXBODEG2_A296cantidad[0];
            n296cantidad = PRODXBODEG2_n296cantidad[0];
            A286PrdCod = PRODXBODEG2_A286PrdCod[0];
            A348stockDetID = PRODXBODEG2_A348stockDetID[0];
            A43TipoInv = PRODXBODEG2_A43TipoInv[0];
            A42BodCod = PRODXBODEG2_A42BodCod[0];
            A2AgeID = PRODXBODEG2_A2AgeID[0];
            A1EmpID = PRODXBODEG2_A1EmpID[0];
            A291stockMes = PRODXBODEG2_A291stockMes[0];
            A290stockAnio = PRODXBODEG2_A290stockAnio[0];
            A43TipoInv = PRODXBODEG2_A43TipoInv[0];
            /*
               INSERT RECORD ON TABLE GXA0083

            */
            AV2stockAnio = A290stockAnio;
            AV3stockMes = A291stockMes;
            AV4EmpID = A1EmpID;
            AV5AgeID = A2AgeID;
            AV6BodCod = A42BodCod;
            AV7TipoInv = A43TipoInv;
            AV8stockDetID = A348stockDetID;
            AV9PrdCod = A286PrdCod;
            if ( PRODXBODEG2_n296cantidad[0] )
            {
               AV10cantidad = 0;
               nV10cantidad = false;
               nV10cantidad = true;
            }
            else
            {
               AV10cantidad = A296cantidad;
               nV10cantidad = false;
            }
            if ( PRODXBODEG2_n297stock[0] )
            {
               AV11stock = 0;
               nV11stock = false;
               nV11stock = true;
            }
            else
            {
               AV11stock = A297stock;
               nV11stock = false;
            }
            if ( PRODXBODEG2_n298costo[0] )
            {
               AV12costo = 0;
               nV12costo = false;
               nV12costo = true;
            }
            else
            {
               AV12costo = A298costo;
               nV12costo = false;
            }
            /* Using cursor PRODXBODEG3 */
            pr_default.execute(1, new Object[] {AV2stockAnio, AV3stockMes, AV4EmpID, AV5AgeID, AV6BodCod, AV7TipoInv, AV8stockDetID, AV9PrdCod, nV10cantidad, AV10cantidad, nV11stock, AV11stock, nV12costo, AV12costo});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0083") ;
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
            /* End Insert */
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
         PRODXBODEG2_A298costo = new decimal[1] ;
         PRODXBODEG2_n298costo = new bool[] {false} ;
         PRODXBODEG2_A297stock = new decimal[1] ;
         PRODXBODEG2_n297stock = new bool[] {false} ;
         PRODXBODEG2_A296cantidad = new decimal[1] ;
         PRODXBODEG2_n296cantidad = new bool[] {false} ;
         PRODXBODEG2_A286PrdCod = new short[1] ;
         PRODXBODEG2_A348stockDetID = new short[1] ;
         PRODXBODEG2_A43TipoInv = new String[] {""} ;
         PRODXBODEG2_A42BodCod = new short[1] ;
         PRODXBODEG2_A2AgeID = new short[1] ;
         PRODXBODEG2_A1EmpID = new short[1] ;
         PRODXBODEG2_A291stockMes = new short[1] ;
         PRODXBODEG2_A290stockAnio = new short[1] ;
         A43TipoInv = "";
         AV7TipoInv = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.prodxbodegatipoconversion__default(),
            new Object[][] {
                new Object[] {
               PRODXBODEG2_A298costo, PRODXBODEG2_n298costo, PRODXBODEG2_A297stock, PRODXBODEG2_n297stock, PRODXBODEG2_A296cantidad, PRODXBODEG2_n296cantidad, PRODXBODEG2_A286PrdCod, PRODXBODEG2_A348stockDetID, PRODXBODEG2_A43TipoInv, PRODXBODEG2_A42BodCod,
               PRODXBODEG2_A2AgeID, PRODXBODEG2_A1EmpID, PRODXBODEG2_A291stockMes, PRODXBODEG2_A290stockAnio
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A286PrdCod ;
      private short A348stockDetID ;
      private short A42BodCod ;
      private short A2AgeID ;
      private short A1EmpID ;
      private short A291stockMes ;
      private short A290stockAnio ;
      private short AV2stockAnio ;
      private short AV3stockMes ;
      private short AV4EmpID ;
      private short AV5AgeID ;
      private short AV6BodCod ;
      private short AV8stockDetID ;
      private short AV9PrdCod ;
      private int GIGXA0083 ;
      private decimal A298costo ;
      private decimal A297stock ;
      private decimal A296cantidad ;
      private decimal AV10cantidad ;
      private decimal AV11stock ;
      private decimal AV12costo ;
      private String scmdbuf ;
      private String A43TipoInv ;
      private String AV7TipoInv ;
      private String Gx_emsg ;
      private bool n298costo ;
      private bool n297stock ;
      private bool n296cantidad ;
      private bool nV10cantidad ;
      private bool nV11stock ;
      private bool nV12costo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] PRODXBODEG2_A298costo ;
      private bool[] PRODXBODEG2_n298costo ;
      private decimal[] PRODXBODEG2_A297stock ;
      private bool[] PRODXBODEG2_n297stock ;
      private decimal[] PRODXBODEG2_A296cantidad ;
      private bool[] PRODXBODEG2_n296cantidad ;
      private short[] PRODXBODEG2_A286PrdCod ;
      private short[] PRODXBODEG2_A348stockDetID ;
      private String[] PRODXBODEG2_A43TipoInv ;
      private short[] PRODXBODEG2_A42BodCod ;
      private short[] PRODXBODEG2_A2AgeID ;
      private short[] PRODXBODEG2_A1EmpID ;
      private short[] PRODXBODEG2_A291stockMes ;
      private short[] PRODXBODEG2_A290stockAnio ;
   }

   public class prodxbodegatipoconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmPRODXBODEG2 ;
          prmPRODXBODEG2 = new Object[] {
          } ;
          Object[] prmPRODXBODEG3 ;
          prmPRODXBODEG3 = new Object[] {
          new Object[] {"@AV2stockAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3stockMes",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV4EmpID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5AgeID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6BodCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7TipoInv",SqlDbType.Char,4,0} ,
          new Object[] {"@AV8stockDetID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9PrdCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cantidad",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV11stock",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV12costo",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("PRODXBODEG2", "SELECT T1.[costo], T1.[stock], T1.[cantidad], T1.[PrdCod], T1.[stockDetID], T2.[TipoInv], T1.[BodCod], T1.[AgeID], T1.[EmpID], T1.[stockMes], T1.[stockAnio] FROM ([ProdxBodegaTipo] T1 INNER JOIN [ProdxBodega] T2 ON T2.[stockAnio] = T1.[stockAnio] AND T2.[stockMes] = T1.[stockMes] AND T2.[EmpID] = T1.[EmpID] AND T2.[AgeID] = T1.[AgeID] AND T2.[BodCod] = T1.[BodCod]) WHERE Not T2.[TipoInv] IS NULL ORDER BY T1.[stockAnio], T1.[stockMes], T1.[EmpID], T1.[AgeID], T1.[BodCod], T1.[stockDetID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPRODXBODEG2,100,0,true,false )
             ,new CursorDef("PRODXBODEG3", "INSERT INTO [GXA0083]([stockAnio], [stockMes], [EmpID], [AgeID], [BodCod], [TipoInv], [stockDetID], [PrdCod], [cantidad], [stock], [costo]) VALUES(@AV2stockAnio, @AV3stockMes, @AV4EmpID, @AV5AgeID, @AV6BodCod, @AV7TipoInv, @AV8stockDetID, @AV9PrdCod, @AV10cantidad, @AV11stock, @AV12costo)", GxErrorMask.GX_NOMASK,prmPRODXBODEG3)
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((String[]) buf[8])[0] = rslt.getString(6, 4) ;
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((short[]) buf[13])[0] = rslt.getShort(11) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 9 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(9, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(10, (decimal)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(11, (decimal)parms[13]);
                }
                return;
       }
    }

 }

}
