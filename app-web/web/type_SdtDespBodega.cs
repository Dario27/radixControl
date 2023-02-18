/*
               File: type_SdtDespBodega
        Description: Despacho Bodega
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 11/27/2022 11:7:13.34
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "DespBodega" )]
   [XmlType(TypeName =  "DespBodega" , Namespace = "KBCalpesa22" )]
   [Serializable]
   public class SdtDespBodega : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtDespBodega( )
      {
      }

      public SdtDespBodega( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( short AV1EmpID ,
                        short AV2AgeID ,
                        short AV353DespBodNro ,
                        short AV354DespBodOpId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV1EmpID,(short)AV2AgeID,(short)AV353DespBodNro,(short)AV354DespBodOpId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"EmpID", typeof(short)}, new Object[]{"AgeID", typeof(short)}, new Object[]{"DespBodNro", typeof(short)}, new Object[]{"DespBodOpId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "DespBodega");
         metadata.Set("BT", "DespBodega");
         metadata.Set("PK", "[ \"EmpID\",\"AgeID\",\"DespBodNro\",\"DespBodOpId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"EmpID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"EmpID\",\"AgeID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"EmpID\",\"BodCod\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Empid_Z");
         state.Add("gxTpr_Empdsc_Z");
         state.Add("gxTpr_Ageid_Z");
         state.Add("gxTpr_Agedsc_Z");
         state.Add("gxTpr_Bodcod_Z");
         state.Add("gxTpr_Boddsc_Z");
         state.Add("gxTpr_Despbodnro_Z");
         state.Add("gxTpr_Despbodopid_Z");
         state.Add("gxTpr_Despbodcodprd_Z");
         state.Add("gxTpr_Despbodprdnombre_Z");
         state.Add("gxTpr_Despbodcant_Z");
         state.Add("gxTpr_Despbodvalor_Z_double");
         state.Add("gxTpr_Despbodadesp_Z");
         state.Add("gxTpr_Despbodstock_Z_double");
         state.Add("gxTpr_Despbodcatid_Z");
         state.Add("gxTpr_Despboddif_Z");
         state.Add("gxTpr_Empdsc_N");
         state.Add("gxTpr_Agedsc_N");
         state.Add("gxTpr_Boddsc_N");
         state.Add("gxTpr_Despbodcodprd_N");
         state.Add("gxTpr_Despbodprdnombre_N");
         state.Add("gxTpr_Despbodcant_N");
         state.Add("gxTpr_Despbodvalor_N");
         state.Add("gxTpr_Despbodadesp_N");
         state.Add("gxTpr_Despbodcatid_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtDespBodega sdt ;
         sdt = (SdtDespBodega)(source);
         gxTv_SdtDespBodega_Empid = sdt.gxTv_SdtDespBodega_Empid ;
         gxTv_SdtDespBodega_Empdsc = sdt.gxTv_SdtDespBodega_Empdsc ;
         gxTv_SdtDespBodega_Ageid = sdt.gxTv_SdtDespBodega_Ageid ;
         gxTv_SdtDespBodega_Agedsc = sdt.gxTv_SdtDespBodega_Agedsc ;
         gxTv_SdtDespBodega_Bodcod = sdt.gxTv_SdtDespBodega_Bodcod ;
         gxTv_SdtDespBodega_Boddsc = sdt.gxTv_SdtDespBodega_Boddsc ;
         gxTv_SdtDespBodega_Despbodnro = sdt.gxTv_SdtDespBodega_Despbodnro ;
         gxTv_SdtDespBodega_Despbodopid = sdt.gxTv_SdtDespBodega_Despbodopid ;
         gxTv_SdtDespBodega_Despbodcodprd = sdt.gxTv_SdtDespBodega_Despbodcodprd ;
         gxTv_SdtDespBodega_Despbodprdnombre = sdt.gxTv_SdtDespBodega_Despbodprdnombre ;
         gxTv_SdtDespBodega_Despbodcant = sdt.gxTv_SdtDespBodega_Despbodcant ;
         gxTv_SdtDespBodega_Despbodvalor = sdt.gxTv_SdtDespBodega_Despbodvalor ;
         gxTv_SdtDespBodega_Despbodadesp = sdt.gxTv_SdtDespBodega_Despbodadesp ;
         gxTv_SdtDespBodega_Despbodstock = sdt.gxTv_SdtDespBodega_Despbodstock ;
         gxTv_SdtDespBodega_Despbodcatid = sdt.gxTv_SdtDespBodega_Despbodcatid ;
         gxTv_SdtDespBodega_Despboddif = sdt.gxTv_SdtDespBodega_Despboddif ;
         gxTv_SdtDespBodega_Mode = sdt.gxTv_SdtDespBodega_Mode ;
         gxTv_SdtDespBodega_Initialized = sdt.gxTv_SdtDespBodega_Initialized ;
         gxTv_SdtDespBodega_Empid_Z = sdt.gxTv_SdtDespBodega_Empid_Z ;
         gxTv_SdtDespBodega_Empdsc_Z = sdt.gxTv_SdtDespBodega_Empdsc_Z ;
         gxTv_SdtDespBodega_Ageid_Z = sdt.gxTv_SdtDespBodega_Ageid_Z ;
         gxTv_SdtDespBodega_Agedsc_Z = sdt.gxTv_SdtDespBodega_Agedsc_Z ;
         gxTv_SdtDespBodega_Bodcod_Z = sdt.gxTv_SdtDespBodega_Bodcod_Z ;
         gxTv_SdtDespBodega_Boddsc_Z = sdt.gxTv_SdtDespBodega_Boddsc_Z ;
         gxTv_SdtDespBodega_Despbodnro_Z = sdt.gxTv_SdtDespBodega_Despbodnro_Z ;
         gxTv_SdtDespBodega_Despbodopid_Z = sdt.gxTv_SdtDespBodega_Despbodopid_Z ;
         gxTv_SdtDespBodega_Despbodcodprd_Z = sdt.gxTv_SdtDespBodega_Despbodcodprd_Z ;
         gxTv_SdtDespBodega_Despbodprdnombre_Z = sdt.gxTv_SdtDespBodega_Despbodprdnombre_Z ;
         gxTv_SdtDespBodega_Despbodcant_Z = sdt.gxTv_SdtDespBodega_Despbodcant_Z ;
         gxTv_SdtDespBodega_Despbodvalor_Z = sdt.gxTv_SdtDespBodega_Despbodvalor_Z ;
         gxTv_SdtDespBodega_Despbodadesp_Z = sdt.gxTv_SdtDespBodega_Despbodadesp_Z ;
         gxTv_SdtDespBodega_Despbodstock_Z = sdt.gxTv_SdtDespBodega_Despbodstock_Z ;
         gxTv_SdtDespBodega_Despbodcatid_Z = sdt.gxTv_SdtDespBodega_Despbodcatid_Z ;
         gxTv_SdtDespBodega_Despboddif_Z = sdt.gxTv_SdtDespBodega_Despboddif_Z ;
         gxTv_SdtDespBodega_Empdsc_N = sdt.gxTv_SdtDespBodega_Empdsc_N ;
         gxTv_SdtDespBodega_Agedsc_N = sdt.gxTv_SdtDespBodega_Agedsc_N ;
         gxTv_SdtDespBodega_Boddsc_N = sdt.gxTv_SdtDespBodega_Boddsc_N ;
         gxTv_SdtDespBodega_Despbodcodprd_N = sdt.gxTv_SdtDespBodega_Despbodcodprd_N ;
         gxTv_SdtDespBodega_Despbodprdnombre_N = sdt.gxTv_SdtDespBodega_Despbodprdnombre_N ;
         gxTv_SdtDespBodega_Despbodcant_N = sdt.gxTv_SdtDespBodega_Despbodcant_N ;
         gxTv_SdtDespBodega_Despbodvalor_N = sdt.gxTv_SdtDespBodega_Despbodvalor_N ;
         gxTv_SdtDespBodega_Despbodadesp_N = sdt.gxTv_SdtDespBodega_Despbodadesp_N ;
         gxTv_SdtDespBodega_Despbodcatid_N = sdt.gxTv_SdtDespBodega_Despbodcatid_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("EmpID", gxTv_SdtDespBodega_Empid, false);
         AddObjectProperty("empdsc", gxTv_SdtDespBodega_Empdsc, false);
         AddObjectProperty("empdsc_N", gxTv_SdtDespBodega_Empdsc_N, false);
         AddObjectProperty("AgeID", gxTv_SdtDespBodega_Ageid, false);
         AddObjectProperty("AgeDsc", gxTv_SdtDespBodega_Agedsc, false);
         AddObjectProperty("AgeDsc_N", gxTv_SdtDespBodega_Agedsc_N, false);
         AddObjectProperty("BodCod", gxTv_SdtDespBodega_Bodcod, false);
         AddObjectProperty("BodDsc", gxTv_SdtDespBodega_Boddsc, false);
         AddObjectProperty("BodDsc_N", gxTv_SdtDespBodega_Boddsc_N, false);
         AddObjectProperty("DespBodNro", gxTv_SdtDespBodega_Despbodnro, false);
         AddObjectProperty("DespBodOpId", gxTv_SdtDespBodega_Despbodopid, false);
         AddObjectProperty("DespBodCodPrd", gxTv_SdtDespBodega_Despbodcodprd, false);
         AddObjectProperty("DespBodCodPrd_N", gxTv_SdtDespBodega_Despbodcodprd_N, false);
         AddObjectProperty("DespBodPrdNombre", gxTv_SdtDespBodega_Despbodprdnombre, false);
         AddObjectProperty("DespBodPrdNombre_N", gxTv_SdtDespBodega_Despbodprdnombre_N, false);
         AddObjectProperty("DespBodCant", gxTv_SdtDespBodega_Despbodcant, false);
         AddObjectProperty("DespBodCant_N", gxTv_SdtDespBodega_Despbodcant_N, false);
         AddObjectProperty("DespBodValor", gxTv_SdtDespBodega_Despbodvalor, false);
         AddObjectProperty("DespBodValor_N", gxTv_SdtDespBodega_Despbodvalor_N, false);
         AddObjectProperty("DespBodADesp", gxTv_SdtDespBodega_Despbodadesp, false);
         AddObjectProperty("DespBodADesp_N", gxTv_SdtDespBodega_Despbodadesp_N, false);
         AddObjectProperty("DespBodStock", gxTv_SdtDespBodega_Despbodstock, false);
         AddObjectProperty("DespBodCatId", gxTv_SdtDespBodega_Despbodcatid, false);
         AddObjectProperty("DespBodCatId_N", gxTv_SdtDespBodega_Despbodcatid_N, false);
         AddObjectProperty("DespBodDif", gxTv_SdtDespBodega_Despboddif, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtDespBodega_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtDespBodega_Initialized, false);
            AddObjectProperty("EmpID_Z", gxTv_SdtDespBodega_Empid_Z, false);
            AddObjectProperty("empdsc_Z", gxTv_SdtDespBodega_Empdsc_Z, false);
            AddObjectProperty("AgeID_Z", gxTv_SdtDespBodega_Ageid_Z, false);
            AddObjectProperty("AgeDsc_Z", gxTv_SdtDespBodega_Agedsc_Z, false);
            AddObjectProperty("BodCod_Z", gxTv_SdtDespBodega_Bodcod_Z, false);
            AddObjectProperty("BodDsc_Z", gxTv_SdtDespBodega_Boddsc_Z, false);
            AddObjectProperty("DespBodNro_Z", gxTv_SdtDespBodega_Despbodnro_Z, false);
            AddObjectProperty("DespBodOpId_Z", gxTv_SdtDespBodega_Despbodopid_Z, false);
            AddObjectProperty("DespBodCodPrd_Z", gxTv_SdtDespBodega_Despbodcodprd_Z, false);
            AddObjectProperty("DespBodPrdNombre_Z", gxTv_SdtDespBodega_Despbodprdnombre_Z, false);
            AddObjectProperty("DespBodCant_Z", gxTv_SdtDespBodega_Despbodcant_Z, false);
            AddObjectProperty("DespBodValor_Z", gxTv_SdtDespBodega_Despbodvalor_Z, false);
            AddObjectProperty("DespBodADesp_Z", gxTv_SdtDespBodega_Despbodadesp_Z, false);
            AddObjectProperty("DespBodStock_Z", gxTv_SdtDespBodega_Despbodstock_Z, false);
            AddObjectProperty("DespBodCatId_Z", gxTv_SdtDespBodega_Despbodcatid_Z, false);
            AddObjectProperty("DespBodDif_Z", gxTv_SdtDespBodega_Despboddif_Z, false);
            AddObjectProperty("empdsc_N", gxTv_SdtDespBodega_Empdsc_N, false);
            AddObjectProperty("AgeDsc_N", gxTv_SdtDespBodega_Agedsc_N, false);
            AddObjectProperty("BodDsc_N", gxTv_SdtDespBodega_Boddsc_N, false);
            AddObjectProperty("DespBodCodPrd_N", gxTv_SdtDespBodega_Despbodcodprd_N, false);
            AddObjectProperty("DespBodPrdNombre_N", gxTv_SdtDespBodega_Despbodprdnombre_N, false);
            AddObjectProperty("DespBodCant_N", gxTv_SdtDespBodega_Despbodcant_N, false);
            AddObjectProperty("DespBodValor_N", gxTv_SdtDespBodega_Despbodvalor_N, false);
            AddObjectProperty("DespBodADesp_N", gxTv_SdtDespBodega_Despbodadesp_N, false);
            AddObjectProperty("DespBodCatId_N", gxTv_SdtDespBodega_Despbodcatid_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtDespBodega sdt )
      {
         if ( sdt.IsDirty("EmpID") )
         {
            gxTv_SdtDespBodega_Empid = sdt.gxTv_SdtDespBodega_Empid ;
         }
         if ( sdt.IsDirty("empdsc") )
         {
            gxTv_SdtDespBodega_Empdsc = sdt.gxTv_SdtDespBodega_Empdsc ;
         }
         if ( sdt.IsDirty("AgeID") )
         {
            gxTv_SdtDespBodega_Ageid = sdt.gxTv_SdtDespBodega_Ageid ;
         }
         if ( sdt.IsDirty("AgeDsc") )
         {
            gxTv_SdtDespBodega_Agedsc = sdt.gxTv_SdtDespBodega_Agedsc ;
         }
         if ( sdt.IsDirty("BodCod") )
         {
            gxTv_SdtDespBodega_Bodcod = sdt.gxTv_SdtDespBodega_Bodcod ;
         }
         if ( sdt.IsDirty("BodDsc") )
         {
            gxTv_SdtDespBodega_Boddsc = sdt.gxTv_SdtDespBodega_Boddsc ;
         }
         if ( sdt.IsDirty("DespBodNro") )
         {
            gxTv_SdtDespBodega_Despbodnro = sdt.gxTv_SdtDespBodega_Despbodnro ;
         }
         if ( sdt.IsDirty("DespBodOpId") )
         {
            gxTv_SdtDespBodega_Despbodopid = sdt.gxTv_SdtDespBodega_Despbodopid ;
         }
         if ( sdt.IsDirty("DespBodCodPrd") )
         {
            gxTv_SdtDespBodega_Despbodcodprd = sdt.gxTv_SdtDespBodega_Despbodcodprd ;
         }
         if ( sdt.IsDirty("DespBodPrdNombre") )
         {
            gxTv_SdtDespBodega_Despbodprdnombre = sdt.gxTv_SdtDespBodega_Despbodprdnombre ;
         }
         if ( sdt.IsDirty("DespBodCant") )
         {
            gxTv_SdtDespBodega_Despbodcant = sdt.gxTv_SdtDespBodega_Despbodcant ;
         }
         if ( sdt.IsDirty("DespBodValor") )
         {
            gxTv_SdtDespBodega_Despbodvalor = sdt.gxTv_SdtDespBodega_Despbodvalor ;
         }
         if ( sdt.IsDirty("DespBodADesp") )
         {
            gxTv_SdtDespBodega_Despbodadesp = sdt.gxTv_SdtDespBodega_Despbodadesp ;
         }
         if ( sdt.IsDirty("DespBodStock") )
         {
            gxTv_SdtDespBodega_Despbodstock = sdt.gxTv_SdtDespBodega_Despbodstock ;
         }
         if ( sdt.IsDirty("DespBodCatId") )
         {
            gxTv_SdtDespBodega_Despbodcatid = sdt.gxTv_SdtDespBodega_Despbodcatid ;
         }
         if ( sdt.IsDirty("DespBodDif") )
         {
            gxTv_SdtDespBodega_Despboddif = sdt.gxTv_SdtDespBodega_Despboddif ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "EmpID" )]
      [  XmlElement( ElementName = "EmpID"   )]
      public short gxTpr_Empid
      {
         get {
            return gxTv_SdtDespBodega_Empid ;
         }

         set {
            if ( gxTv_SdtDespBodega_Empid != value )
            {
               gxTv_SdtDespBodega_Mode = "INS";
               this.gxTv_SdtDespBodega_Empid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Empdsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Ageid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Agedsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Bodcod_Z_SetNull( );
               this.gxTv_SdtDespBodega_Boddsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodnro_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodopid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcodprd_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodprdnombre_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcant_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodvalor_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodadesp_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodstock_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcatid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despboddif_Z_SetNull( );
            }
            gxTv_SdtDespBodega_Empid = value;
            SetDirty("Empid");
         }

      }

      [  SoapElement( ElementName = "empdsc" )]
      [  XmlElement( ElementName = "empdsc"   )]
      public String gxTpr_Empdsc
      {
         get {
            return gxTv_SdtDespBodega_Empdsc ;
         }

         set {
            gxTv_SdtDespBodega_Empdsc_N = 0;
            gxTv_SdtDespBodega_Empdsc = value;
            SetDirty("Empdsc");
         }

      }

      public void gxTv_SdtDespBodega_Empdsc_SetNull( )
      {
         gxTv_SdtDespBodega_Empdsc_N = 1;
         gxTv_SdtDespBodega_Empdsc = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Empdsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "AgeID" )]
      [  XmlElement( ElementName = "AgeID"   )]
      public short gxTpr_Ageid
      {
         get {
            return gxTv_SdtDespBodega_Ageid ;
         }

         set {
            if ( gxTv_SdtDespBodega_Ageid != value )
            {
               gxTv_SdtDespBodega_Mode = "INS";
               this.gxTv_SdtDespBodega_Empid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Empdsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Ageid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Agedsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Bodcod_Z_SetNull( );
               this.gxTv_SdtDespBodega_Boddsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodnro_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodopid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcodprd_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodprdnombre_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcant_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodvalor_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodadesp_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodstock_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcatid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despboddif_Z_SetNull( );
            }
            gxTv_SdtDespBodega_Ageid = value;
            SetDirty("Ageid");
         }

      }

      [  SoapElement( ElementName = "AgeDsc" )]
      [  XmlElement( ElementName = "AgeDsc"   )]
      public String gxTpr_Agedsc
      {
         get {
            return gxTv_SdtDespBodega_Agedsc ;
         }

         set {
            gxTv_SdtDespBodega_Agedsc_N = 0;
            gxTv_SdtDespBodega_Agedsc = value;
            SetDirty("Agedsc");
         }

      }

      public void gxTv_SdtDespBodega_Agedsc_SetNull( )
      {
         gxTv_SdtDespBodega_Agedsc_N = 1;
         gxTv_SdtDespBodega_Agedsc = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Agedsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BodCod" )]
      [  XmlElement( ElementName = "BodCod"   )]
      public short gxTpr_Bodcod
      {
         get {
            return gxTv_SdtDespBodega_Bodcod ;
         }

         set {
            gxTv_SdtDespBodega_Bodcod = value;
            SetDirty("Bodcod");
         }

      }

      [  SoapElement( ElementName = "BodDsc" )]
      [  XmlElement( ElementName = "BodDsc"   )]
      public String gxTpr_Boddsc
      {
         get {
            return gxTv_SdtDespBodega_Boddsc ;
         }

         set {
            gxTv_SdtDespBodega_Boddsc_N = 0;
            gxTv_SdtDespBodega_Boddsc = value;
            SetDirty("Boddsc");
         }

      }

      public void gxTv_SdtDespBodega_Boddsc_SetNull( )
      {
         gxTv_SdtDespBodega_Boddsc_N = 1;
         gxTv_SdtDespBodega_Boddsc = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Boddsc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodNro" )]
      [  XmlElement( ElementName = "DespBodNro"   )]
      public short gxTpr_Despbodnro
      {
         get {
            return gxTv_SdtDespBodega_Despbodnro ;
         }

         set {
            if ( gxTv_SdtDespBodega_Despbodnro != value )
            {
               gxTv_SdtDespBodega_Mode = "INS";
               this.gxTv_SdtDespBodega_Empid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Empdsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Ageid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Agedsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Bodcod_Z_SetNull( );
               this.gxTv_SdtDespBodega_Boddsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodnro_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodopid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcodprd_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodprdnombre_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcant_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodvalor_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodadesp_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodstock_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcatid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despboddif_Z_SetNull( );
            }
            gxTv_SdtDespBodega_Despbodnro = value;
            SetDirty("Despbodnro");
         }

      }

      [  SoapElement( ElementName = "DespBodOpId" )]
      [  XmlElement( ElementName = "DespBodOpId"   )]
      public short gxTpr_Despbodopid
      {
         get {
            return gxTv_SdtDespBodega_Despbodopid ;
         }

         set {
            if ( gxTv_SdtDespBodega_Despbodopid != value )
            {
               gxTv_SdtDespBodega_Mode = "INS";
               this.gxTv_SdtDespBodega_Empid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Empdsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Ageid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Agedsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Bodcod_Z_SetNull( );
               this.gxTv_SdtDespBodega_Boddsc_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodnro_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodopid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcodprd_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodprdnombre_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcant_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodvalor_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodadesp_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodstock_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despbodcatid_Z_SetNull( );
               this.gxTv_SdtDespBodega_Despboddif_Z_SetNull( );
            }
            gxTv_SdtDespBodega_Despbodopid = value;
            SetDirty("Despbodopid");
         }

      }

      [  SoapElement( ElementName = "DespBodCodPrd" )]
      [  XmlElement( ElementName = "DespBodCodPrd"   )]
      public short gxTpr_Despbodcodprd
      {
         get {
            return gxTv_SdtDespBodega_Despbodcodprd ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcodprd_N = 0;
            gxTv_SdtDespBodega_Despbodcodprd = value;
            SetDirty("Despbodcodprd");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcodprd_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcodprd_N = 1;
         gxTv_SdtDespBodega_Despbodcodprd = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcodprd_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodPrdNombre" )]
      [  XmlElement( ElementName = "DespBodPrdNombre"   )]
      public String gxTpr_Despbodprdnombre
      {
         get {
            return gxTv_SdtDespBodega_Despbodprdnombre ;
         }

         set {
            gxTv_SdtDespBodega_Despbodprdnombre_N = 0;
            gxTv_SdtDespBodega_Despbodprdnombre = value;
            SetDirty("Despbodprdnombre");
         }

      }

      public void gxTv_SdtDespBodega_Despbodprdnombre_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodprdnombre_N = 1;
         gxTv_SdtDespBodega_Despbodprdnombre = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodprdnombre_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCant" )]
      [  XmlElement( ElementName = "DespBodCant"   )]
      public int gxTpr_Despbodcant
      {
         get {
            return gxTv_SdtDespBodega_Despbodcant ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcant_N = 0;
            gxTv_SdtDespBodega_Despbodcant = value;
            SetDirty("Despbodcant");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcant_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcant_N = 1;
         gxTv_SdtDespBodega_Despbodcant = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcant_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodValor" )]
      [  XmlElement( ElementName = "DespBodValor"   )]
      public double gxTpr_Despbodvalor_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtDespBodega_Despbodvalor) ;
         }

         set {
            gxTv_SdtDespBodega_Despbodvalor_N = 0;
            gxTv_SdtDespBodega_Despbodvalor = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Despbodvalor
      {
         get {
            return gxTv_SdtDespBodega_Despbodvalor ;
         }

         set {
            gxTv_SdtDespBodega_Despbodvalor_N = 0;
            gxTv_SdtDespBodega_Despbodvalor = value;
            SetDirty("Despbodvalor");
         }

      }

      public void gxTv_SdtDespBodega_Despbodvalor_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodvalor_N = 1;
         gxTv_SdtDespBodega_Despbodvalor = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodvalor_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodADesp" )]
      [  XmlElement( ElementName = "DespBodADesp"   )]
      public int gxTpr_Despbodadesp
      {
         get {
            return gxTv_SdtDespBodega_Despbodadesp ;
         }

         set {
            gxTv_SdtDespBodega_Despbodadesp_N = 0;
            gxTv_SdtDespBodega_Despbodadesp = value;
            SetDirty("Despbodadesp");
         }

      }

      public void gxTv_SdtDespBodega_Despbodadesp_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodadesp_N = 1;
         gxTv_SdtDespBodega_Despbodadesp = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodadesp_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodStock" )]
      [  XmlElement( ElementName = "DespBodStock"   )]
      public double gxTpr_Despbodstock_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtDespBodega_Despbodstock) ;
         }

         set {
            gxTv_SdtDespBodega_Despbodstock = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Despbodstock
      {
         get {
            return gxTv_SdtDespBodega_Despbodstock ;
         }

         set {
            gxTv_SdtDespBodega_Despbodstock = value;
            SetDirty("Despbodstock");
         }

      }

      public void gxTv_SdtDespBodega_Despbodstock_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodstock = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodstock_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCatId" )]
      [  XmlElement( ElementName = "DespBodCatId"   )]
      public short gxTpr_Despbodcatid
      {
         get {
            return gxTv_SdtDespBodega_Despbodcatid ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcatid_N = 0;
            gxTv_SdtDespBodega_Despbodcatid = value;
            SetDirty("Despbodcatid");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcatid_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcatid_N = 1;
         gxTv_SdtDespBodega_Despbodcatid = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcatid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodDif" )]
      [  XmlElement( ElementName = "DespBodDif"   )]
      public short gxTpr_Despboddif
      {
         get {
            return gxTv_SdtDespBodega_Despboddif ;
         }

         set {
            gxTv_SdtDespBodega_Despboddif = value;
            SetDirty("Despboddif");
         }

      }

      public void gxTv_SdtDespBodega_Despboddif_SetNull( )
      {
         gxTv_SdtDespBodega_Despboddif = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despboddif_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtDespBodega_Mode ;
         }

         set {
            gxTv_SdtDespBodega_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtDespBodega_Mode_SetNull( )
      {
         gxTv_SdtDespBodega_Mode = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtDespBodega_Initialized ;
         }

         set {
            gxTv_SdtDespBodega_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtDespBodega_Initialized_SetNull( )
      {
         gxTv_SdtDespBodega_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EmpID_Z" )]
      [  XmlElement( ElementName = "EmpID_Z"   )]
      public short gxTpr_Empid_Z
      {
         get {
            return gxTv_SdtDespBodega_Empid_Z ;
         }

         set {
            gxTv_SdtDespBodega_Empid_Z = value;
            SetDirty("Empid_Z");
         }

      }

      public void gxTv_SdtDespBodega_Empid_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Empid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Empid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empdsc_Z" )]
      [  XmlElement( ElementName = "empdsc_Z"   )]
      public String gxTpr_Empdsc_Z
      {
         get {
            return gxTv_SdtDespBodega_Empdsc_Z ;
         }

         set {
            gxTv_SdtDespBodega_Empdsc_Z = value;
            SetDirty("Empdsc_Z");
         }

      }

      public void gxTv_SdtDespBodega_Empdsc_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Empdsc_Z = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Empdsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "AgeID_Z" )]
      [  XmlElement( ElementName = "AgeID_Z"   )]
      public short gxTpr_Ageid_Z
      {
         get {
            return gxTv_SdtDespBodega_Ageid_Z ;
         }

         set {
            gxTv_SdtDespBodega_Ageid_Z = value;
            SetDirty("Ageid_Z");
         }

      }

      public void gxTv_SdtDespBodega_Ageid_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Ageid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Ageid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "AgeDsc_Z" )]
      [  XmlElement( ElementName = "AgeDsc_Z"   )]
      public String gxTpr_Agedsc_Z
      {
         get {
            return gxTv_SdtDespBodega_Agedsc_Z ;
         }

         set {
            gxTv_SdtDespBodega_Agedsc_Z = value;
            SetDirty("Agedsc_Z");
         }

      }

      public void gxTv_SdtDespBodega_Agedsc_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Agedsc_Z = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Agedsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BodCod_Z" )]
      [  XmlElement( ElementName = "BodCod_Z"   )]
      public short gxTpr_Bodcod_Z
      {
         get {
            return gxTv_SdtDespBodega_Bodcod_Z ;
         }

         set {
            gxTv_SdtDespBodega_Bodcod_Z = value;
            SetDirty("Bodcod_Z");
         }

      }

      public void gxTv_SdtDespBodega_Bodcod_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Bodcod_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Bodcod_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BodDsc_Z" )]
      [  XmlElement( ElementName = "BodDsc_Z"   )]
      public String gxTpr_Boddsc_Z
      {
         get {
            return gxTv_SdtDespBodega_Boddsc_Z ;
         }

         set {
            gxTv_SdtDespBodega_Boddsc_Z = value;
            SetDirty("Boddsc_Z");
         }

      }

      public void gxTv_SdtDespBodega_Boddsc_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Boddsc_Z = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Boddsc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodNro_Z" )]
      [  XmlElement( ElementName = "DespBodNro_Z"   )]
      public short gxTpr_Despbodnro_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodnro_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodnro_Z = value;
            SetDirty("Despbodnro_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodnro_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodnro_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodnro_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodOpId_Z" )]
      [  XmlElement( ElementName = "DespBodOpId_Z"   )]
      public short gxTpr_Despbodopid_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodopid_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodopid_Z = value;
            SetDirty("Despbodopid_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodopid_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodopid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodopid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCodPrd_Z" )]
      [  XmlElement( ElementName = "DespBodCodPrd_Z"   )]
      public short gxTpr_Despbodcodprd_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodcodprd_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcodprd_Z = value;
            SetDirty("Despbodcodprd_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcodprd_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcodprd_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcodprd_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodPrdNombre_Z" )]
      [  XmlElement( ElementName = "DespBodPrdNombre_Z"   )]
      public String gxTpr_Despbodprdnombre_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodprdnombre_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodprdnombre_Z = value;
            SetDirty("Despbodprdnombre_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodprdnombre_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodprdnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodprdnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCant_Z" )]
      [  XmlElement( ElementName = "DespBodCant_Z"   )]
      public int gxTpr_Despbodcant_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodcant_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcant_Z = value;
            SetDirty("Despbodcant_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcant_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcant_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcant_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodValor_Z" )]
      [  XmlElement( ElementName = "DespBodValor_Z"   )]
      public double gxTpr_Despbodvalor_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtDespBodega_Despbodvalor_Z) ;
         }

         set {
            gxTv_SdtDespBodega_Despbodvalor_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Despbodvalor_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodvalor_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodvalor_Z = value;
            SetDirty("Despbodvalor_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodvalor_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodvalor_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodvalor_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodADesp_Z" )]
      [  XmlElement( ElementName = "DespBodADesp_Z"   )]
      public int gxTpr_Despbodadesp_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodadesp_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodadesp_Z = value;
            SetDirty("Despbodadesp_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodadesp_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodadesp_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodadesp_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodStock_Z" )]
      [  XmlElement( ElementName = "DespBodStock_Z"   )]
      public double gxTpr_Despbodstock_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtDespBodega_Despbodstock_Z) ;
         }

         set {
            gxTv_SdtDespBodega_Despbodstock_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Despbodstock_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodstock_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodstock_Z = value;
            SetDirty("Despbodstock_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodstock_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodstock_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodstock_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCatId_Z" )]
      [  XmlElement( ElementName = "DespBodCatId_Z"   )]
      public short gxTpr_Despbodcatid_Z
      {
         get {
            return gxTv_SdtDespBodega_Despbodcatid_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcatid_Z = value;
            SetDirty("Despbodcatid_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcatid_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcatid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcatid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodDif_Z" )]
      [  XmlElement( ElementName = "DespBodDif_Z"   )]
      public short gxTpr_Despboddif_Z
      {
         get {
            return gxTv_SdtDespBodega_Despboddif_Z ;
         }

         set {
            gxTv_SdtDespBodega_Despboddif_Z = value;
            SetDirty("Despboddif_Z");
         }

      }

      public void gxTv_SdtDespBodega_Despboddif_Z_SetNull( )
      {
         gxTv_SdtDespBodega_Despboddif_Z = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despboddif_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empdsc_N" )]
      [  XmlElement( ElementName = "empdsc_N"   )]
      public short gxTpr_Empdsc_N
      {
         get {
            return gxTv_SdtDespBodega_Empdsc_N ;
         }

         set {
            gxTv_SdtDespBodega_Empdsc_N = value;
            SetDirty("Empdsc_N");
         }

      }

      public void gxTv_SdtDespBodega_Empdsc_N_SetNull( )
      {
         gxTv_SdtDespBodega_Empdsc_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Empdsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "AgeDsc_N" )]
      [  XmlElement( ElementName = "AgeDsc_N"   )]
      public short gxTpr_Agedsc_N
      {
         get {
            return gxTv_SdtDespBodega_Agedsc_N ;
         }

         set {
            gxTv_SdtDespBodega_Agedsc_N = value;
            SetDirty("Agedsc_N");
         }

      }

      public void gxTv_SdtDespBodega_Agedsc_N_SetNull( )
      {
         gxTv_SdtDespBodega_Agedsc_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Agedsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BodDsc_N" )]
      [  XmlElement( ElementName = "BodDsc_N"   )]
      public short gxTpr_Boddsc_N
      {
         get {
            return gxTv_SdtDespBodega_Boddsc_N ;
         }

         set {
            gxTv_SdtDespBodega_Boddsc_N = value;
            SetDirty("Boddsc_N");
         }

      }

      public void gxTv_SdtDespBodega_Boddsc_N_SetNull( )
      {
         gxTv_SdtDespBodega_Boddsc_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Boddsc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCodPrd_N" )]
      [  XmlElement( ElementName = "DespBodCodPrd_N"   )]
      public short gxTpr_Despbodcodprd_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodcodprd_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcodprd_N = value;
            SetDirty("Despbodcodprd_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcodprd_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcodprd_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcodprd_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodPrdNombre_N" )]
      [  XmlElement( ElementName = "DespBodPrdNombre_N"   )]
      public short gxTpr_Despbodprdnombre_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodprdnombre_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodprdnombre_N = value;
            SetDirty("Despbodprdnombre_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodprdnombre_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodprdnombre_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodprdnombre_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCant_N" )]
      [  XmlElement( ElementName = "DespBodCant_N"   )]
      public short gxTpr_Despbodcant_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodcant_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcant_N = value;
            SetDirty("Despbodcant_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcant_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcant_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcant_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodValor_N" )]
      [  XmlElement( ElementName = "DespBodValor_N"   )]
      public short gxTpr_Despbodvalor_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodvalor_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodvalor_N = value;
            SetDirty("Despbodvalor_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodvalor_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodvalor_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodvalor_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodADesp_N" )]
      [  XmlElement( ElementName = "DespBodADesp_N"   )]
      public short gxTpr_Despbodadesp_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodadesp_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodadesp_N = value;
            SetDirty("Despbodadesp_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodadesp_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodadesp_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodadesp_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DespBodCatId_N" )]
      [  XmlElement( ElementName = "DespBodCatId_N"   )]
      public short gxTpr_Despbodcatid_N
      {
         get {
            return gxTv_SdtDespBodega_Despbodcatid_N ;
         }

         set {
            gxTv_SdtDespBodega_Despbodcatid_N = value;
            SetDirty("Despbodcatid_N");
         }

      }

      public void gxTv_SdtDespBodega_Despbodcatid_N_SetNull( )
      {
         gxTv_SdtDespBodega_Despbodcatid_N = 0;
         return  ;
      }

      public bool gxTv_SdtDespBodega_Despbodcatid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtDespBodega_Empdsc = "";
         gxTv_SdtDespBodega_Agedsc = "";
         gxTv_SdtDespBodega_Boddsc = "";
         gxTv_SdtDespBodega_Despbodprdnombre = "";
         gxTv_SdtDespBodega_Mode = "";
         gxTv_SdtDespBodega_Empdsc_Z = "";
         gxTv_SdtDespBodega_Agedsc_Z = "";
         gxTv_SdtDespBodega_Boddsc_Z = "";
         gxTv_SdtDespBodega_Despbodprdnombre_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "despbodega", "GeneXus.Programs.despbodega_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtDespBodega_Empid ;
      private short gxTv_SdtDespBodega_Ageid ;
      private short gxTv_SdtDespBodega_Bodcod ;
      private short gxTv_SdtDespBodega_Despbodnro ;
      private short gxTv_SdtDespBodega_Despbodopid ;
      private short gxTv_SdtDespBodega_Despbodcodprd ;
      private short gxTv_SdtDespBodega_Despbodcatid ;
      private short gxTv_SdtDespBodega_Despboddif ;
      private short gxTv_SdtDespBodega_Initialized ;
      private short gxTv_SdtDespBodega_Empid_Z ;
      private short gxTv_SdtDespBodega_Ageid_Z ;
      private short gxTv_SdtDespBodega_Bodcod_Z ;
      private short gxTv_SdtDespBodega_Despbodnro_Z ;
      private short gxTv_SdtDespBodega_Despbodopid_Z ;
      private short gxTv_SdtDespBodega_Despbodcodprd_Z ;
      private short gxTv_SdtDespBodega_Despbodcatid_Z ;
      private short gxTv_SdtDespBodega_Despboddif_Z ;
      private short gxTv_SdtDespBodega_Empdsc_N ;
      private short gxTv_SdtDespBodega_Agedsc_N ;
      private short gxTv_SdtDespBodega_Boddsc_N ;
      private short gxTv_SdtDespBodega_Despbodcodprd_N ;
      private short gxTv_SdtDespBodega_Despbodprdnombre_N ;
      private short gxTv_SdtDespBodega_Despbodcant_N ;
      private short gxTv_SdtDespBodega_Despbodvalor_N ;
      private short gxTv_SdtDespBodega_Despbodadesp_N ;
      private short gxTv_SdtDespBodega_Despbodcatid_N ;
      private int gxTv_SdtDespBodega_Despbodcant ;
      private int gxTv_SdtDespBodega_Despbodadesp ;
      private int gxTv_SdtDespBodega_Despbodcant_Z ;
      private int gxTv_SdtDespBodega_Despbodadesp_Z ;
      private decimal gxTv_SdtDespBodega_Despbodvalor ;
      private decimal gxTv_SdtDespBodega_Despbodstock ;
      private decimal gxTv_SdtDespBodega_Despbodvalor_Z ;
      private decimal gxTv_SdtDespBodega_Despbodstock_Z ;
      private String gxTv_SdtDespBodega_Agedsc ;
      private String gxTv_SdtDespBodega_Boddsc ;
      private String gxTv_SdtDespBodega_Despbodprdnombre ;
      private String gxTv_SdtDespBodega_Mode ;
      private String gxTv_SdtDespBodega_Agedsc_Z ;
      private String gxTv_SdtDespBodega_Boddsc_Z ;
      private String gxTv_SdtDespBodega_Despbodprdnombre_Z ;
      private String gxTv_SdtDespBodega_Empdsc ;
      private String gxTv_SdtDespBodega_Empdsc_Z ;
   }

   [DataContract(Name = @"DespBodega", Namespace = "KBCalpesa22")]
   public class SdtDespBodega_RESTInterface : GxGenericCollectionItem<SdtDespBodega>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtDespBodega_RESTInterface( ) : base()
      {
      }

      public SdtDespBodega_RESTInterface( SdtDespBodega psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "EmpID" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Empid
      {
         get {
            return sdt.gxTpr_Empid ;
         }

         set {
            sdt.gxTpr_Empid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "empdsc" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Empdsc
      {
         get {
            return sdt.gxTpr_Empdsc ;
         }

         set {
            sdt.gxTpr_Empdsc = value;
         }

      }

      [DataMember( Name = "AgeID" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Ageid
      {
         get {
            return sdt.gxTpr_Ageid ;
         }

         set {
            sdt.gxTpr_Ageid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "AgeDsc" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Agedsc
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Agedsc) ;
         }

         set {
            sdt.gxTpr_Agedsc = value;
         }

      }

      [DataMember( Name = "BodCod" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Bodcod
      {
         get {
            return sdt.gxTpr_Bodcod ;
         }

         set {
            sdt.gxTpr_Bodcod = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BodDsc" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Boddsc
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Boddsc) ;
         }

         set {
            sdt.gxTpr_Boddsc = value;
         }

      }

      [DataMember( Name = "DespBodNro" , Order = 6 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Despbodnro
      {
         get {
            return sdt.gxTpr_Despbodnro ;
         }

         set {
            sdt.gxTpr_Despbodnro = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodOpId" , Order = 7 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Despbodopid
      {
         get {
            return sdt.gxTpr_Despbodopid ;
         }

         set {
            sdt.gxTpr_Despbodopid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodCodPrd" , Order = 8 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Despbodcodprd
      {
         get {
            return sdt.gxTpr_Despbodcodprd ;
         }

         set {
            sdt.gxTpr_Despbodcodprd = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodPrdNombre" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Despbodprdnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Despbodprdnombre) ;
         }

         set {
            sdt.gxTpr_Despbodprdnombre = value;
         }

      }

      [DataMember( Name = "DespBodCant" , Order = 10 )]
      [GxSeudo()]
      public Nullable<int> gxTpr_Despbodcant
      {
         get {
            return sdt.gxTpr_Despbodcant ;
         }

         set {
            sdt.gxTpr_Despbodcant = (int)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodValor" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Despbodvalor
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Despbodvalor, 8, 2)) ;
         }

         set {
            sdt.gxTpr_Despbodvalor = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "DespBodADesp" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Despbodadesp
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Despbodadesp), 8, 0)) ;
         }

         set {
            sdt.gxTpr_Despbodadesp = (int)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "DespBodStock" , Order = 13 )]
      [GxSeudo()]
      public Nullable<decimal> gxTpr_Despbodstock
      {
         get {
            return sdt.gxTpr_Despbodstock ;
         }

         set {
            sdt.gxTpr_Despbodstock = (decimal)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodCatId" , Order = 14 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Despbodcatid
      {
         get {
            return sdt.gxTpr_Despbodcatid ;
         }

         set {
            sdt.gxTpr_Despbodcatid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "DespBodDif" , Order = 15 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Despboddif
      {
         get {
            return sdt.gxTpr_Despboddif ;
         }

         set {
            sdt.gxTpr_Despboddif = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtDespBodega sdt
      {
         get {
            return (SdtDespBodega)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtDespBodega() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 16 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
