/*
               File: valExistCorreo
        Description: val Exist Correo
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:30.4
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
   public class valexistcorreo : GXProcedure
   {
      public valexistcorreo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public valexistcorreo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsuCod ,
                           out bool aP1_respuesta )
      {
         this.AV9UsuCod = aP0_UsuCod;
         this.AV8respuesta = false ;
         initialize();
         executePrivate();
         aP1_respuesta=this.AV8respuesta;
      }

      public bool executeUdp( String aP0_UsuCod )
      {
         this.AV9UsuCod = aP0_UsuCod;
         this.AV8respuesta = false ;
         initialize();
         executePrivate();
         aP1_respuesta=this.AV8respuesta;
         return AV8respuesta ;
      }

      public void executeSubmit( String aP0_UsuCod ,
                                 out bool aP1_respuesta )
      {
         valexistcorreo objvalexistcorreo;
         objvalexistcorreo = new valexistcorreo();
         objvalexistcorreo.AV9UsuCod = aP0_UsuCod;
         objvalexistcorreo.AV8respuesta = false ;
         objvalexistcorreo.context.SetSubmitInitialConfig(context);
         objvalexistcorreo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objvalexistcorreo);
         aP1_respuesta=this.AV8respuesta;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((valexistcorreo)stateInfo).executePrivate();
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
         /* Using cursor P000F2 */
         pr_default.execute(0, new Object[] {AV9UsuCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3UsuCod = P000F2_A3UsuCod[0];
            A52UsuEst = P000F2_A52UsuEst[0];
            n52UsuEst = P000F2_n52UsuEst[0];
            A90UsuCorreo = P000F2_A90UsuCorreo[0];
            n90UsuCorreo = P000F2_n90UsuCorreo[0];
            AV10UsuCorreo = A90UsuCorreo;
            /* Execute user subroutine: 'BUSCORREOUSER' */
            S111 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'BUSCORREOUSER' Routine */
         AV14GXLvl10 = 0;
         /* Using cursor P000F3 */
         pr_default.execute(1, new Object[] {AV9UsuCod, AV10UsuCorreo});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A90UsuCorreo = P000F3_A90UsuCorreo[0];
            n90UsuCorreo = P000F3_n90UsuCorreo[0];
            A3UsuCod = P000F3_A3UsuCod[0];
            A52UsuEst = P000F3_A52UsuEst[0];
            n52UsuEst = P000F3_n52UsuEst[0];
            AV14GXLvl10 = 1;
            AV8respuesta = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV14GXLvl10 == 0 )
         {
            AV8respuesta = false;
         }
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
         P000F2_A3UsuCod = new String[] {""} ;
         P000F2_A52UsuEst = new String[] {""} ;
         P000F2_n52UsuEst = new bool[] {false} ;
         P000F2_A90UsuCorreo = new String[] {""} ;
         P000F2_n90UsuCorreo = new bool[] {false} ;
         A3UsuCod = "";
         A52UsuEst = "";
         A90UsuCorreo = "";
         AV10UsuCorreo = "";
         P000F3_A90UsuCorreo = new String[] {""} ;
         P000F3_n90UsuCorreo = new bool[] {false} ;
         P000F3_A3UsuCod = new String[] {""} ;
         P000F3_A52UsuEst = new String[] {""} ;
         P000F3_n52UsuEst = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.valexistcorreo__default(),
            new Object[][] {
                new Object[] {
               P000F2_A3UsuCod, P000F2_A52UsuEst, P000F2_n52UsuEst, P000F2_A90UsuCorreo, P000F2_n90UsuCorreo
               }
               , new Object[] {
               P000F3_A90UsuCorreo, P000F3_n90UsuCorreo, P000F3_A3UsuCod, P000F3_A52UsuEst, P000F3_n52UsuEst
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV14GXLvl10 ;
      private String AV9UsuCod ;
      private String scmdbuf ;
      private String A3UsuCod ;
      private String A52UsuEst ;
      private String A90UsuCorreo ;
      private String AV10UsuCorreo ;
      private bool AV8respuesta ;
      private bool n52UsuEst ;
      private bool n90UsuCorreo ;
      private bool returnInSub ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000F2_A3UsuCod ;
      private String[] P000F2_A52UsuEst ;
      private bool[] P000F2_n52UsuEst ;
      private String[] P000F2_A90UsuCorreo ;
      private bool[] P000F2_n90UsuCorreo ;
      private String[] P000F3_A90UsuCorreo ;
      private bool[] P000F3_n90UsuCorreo ;
      private String[] P000F3_A3UsuCod ;
      private String[] P000F3_A52UsuEst ;
      private bool[] P000F3_n52UsuEst ;
      private bool aP1_respuesta ;
   }

   public class valexistcorreo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000F2 ;
          prmP000F2 = new Object[] {
          new Object[] {"@AV9UsuCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmP000F3 ;
          prmP000F3 = new Object[] {
          new Object[] {"@AV9UsuCod",SqlDbType.Char,15,0} ,
          new Object[] {"@AV10UsuCorreo",SqlDbType.Char,60,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000F2", "SELECT [UsuCod], [UsuEst], [UsuCorreo] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV9UsuCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F2,1,0,true,true )
             ,new CursorDef("P000F3", "SELECT [UsuCorreo], [UsuCod], [UsuEst] FROM [Usuarios] WITH (NOLOCK) WHERE ([UsuCod] = @AV9UsuCod) AND ([UsuCorreo] = @AV10UsuCorreo) ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F3,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 60) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
