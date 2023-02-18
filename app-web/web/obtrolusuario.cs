/*
               File: obtRolUsuario
        Description: obtener Rol Usuario
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 1/11/2023 0:42:29.91
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
   public class obtrolusuario : GXProcedure
   {
      public obtrolusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public obtrolusuario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsuCod ,
                           out String aP1_rol )
      {
         this.AV9UsuCod = aP0_UsuCod;
         this.AV8rol = "" ;
         initialize();
         executePrivate();
         aP1_rol=this.AV8rol;
      }

      public String executeUdp( String aP0_UsuCod )
      {
         this.AV9UsuCod = aP0_UsuCod;
         this.AV8rol = "" ;
         initialize();
         executePrivate();
         aP1_rol=this.AV8rol;
         return AV8rol ;
      }

      public void executeSubmit( String aP0_UsuCod ,
                                 out String aP1_rol )
      {
         obtrolusuario objobtrolusuario;
         objobtrolusuario = new obtrolusuario();
         objobtrolusuario.AV9UsuCod = aP0_UsuCod;
         objobtrolusuario.AV8rol = "" ;
         objobtrolusuario.context.SetSubmitInitialConfig(context);
         objobtrolusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtrolusuario);
         aP1_rol=this.AV8rol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtrolusuario)stateInfo).executePrivate();
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
         /* Using cursor P000G2 */
         pr_default.execute(0, new Object[] {AV9UsuCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3UsuCod = P000G2_A3UsuCod[0];
            A53UsuRol = P000G2_A53UsuRol[0];
            n53UsuRol = P000G2_n53UsuRol[0];
            AV8rol = StringUtil.Trim( A53UsuRol);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
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
         P000G2_A3UsuCod = new String[] {""} ;
         P000G2_A53UsuRol = new String[] {""} ;
         P000G2_n53UsuRol = new bool[] {false} ;
         A3UsuCod = "";
         A53UsuRol = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtrolusuario__default(),
            new Object[][] {
                new Object[] {
               P000G2_A3UsuCod, P000G2_A53UsuRol, P000G2_n53UsuRol
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV9UsuCod ;
      private String AV8rol ;
      private String scmdbuf ;
      private String A3UsuCod ;
      private String A53UsuRol ;
      private bool n53UsuRol ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000G2_A3UsuCod ;
      private String[] P000G2_A53UsuRol ;
      private bool[] P000G2_n53UsuRol ;
      private String aP1_rol ;
   }

   public class obtrolusuario__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000G2 ;
          prmP000G2 = new Object[] {
          new Object[] {"@AV9UsuCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000G2", "SELECT TOP 1 [UsuCod], [UsuRol] FROM [Usuarios] WITH (NOLOCK) WHERE [UsuCod] = @AV9UsuCod ORDER BY [UsuCod] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G2,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 5) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
       }
    }

 }

}
