/*
				   File: type_SdtSDTPedidos_SDTPedidosItem
			Description: SDTPedidos
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 26/10/2022 20:18:57
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
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="SDTPedidosItem")]
	[XmlType(TypeName="SDTPedidosItem" , Namespace="KBCalpesa22" )]
	[Serializable]
	public class SdtSDTPedidos_SDTPedidosItem : GxUserType
	{
		public SdtSDTPedidos_SDTPedidosItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDTPedidos_SDTPedidosItem_Items = "";

		}

		public SdtSDTPedidos_SDTPedidosItem(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("nro", gxTpr_Nro, false);
			AddObjectProperty("tipProd", gxTpr_Tipprod, false);
			AddObjectProperty("catId", gxTpr_Catid, false);
			AddObjectProperty("subCatId", gxTpr_Subcatid, false);
			AddObjectProperty("items", gxTpr_Items, false);
			AddObjectProperty("cant", gxTpr_Cant, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="nro")]
		[XmlElement(ElementName="nro")]
		public short gxTpr_Nro
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Nro; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Nro = value;
				SetDirty("Nro");
			}
		}


		[SoapElement(ElementName="tipProd")]
		[XmlElement(ElementName="tipProd")]
		public short gxTpr_Tipprod
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Tipprod; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Tipprod = value;
				SetDirty("Tipprod");
			}
		}


		[SoapElement(ElementName="catId")]
		[XmlElement(ElementName="catId")]
		public short gxTpr_Catid
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Catid; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Catid = value;
				SetDirty("Catid");
			}
		}


		[SoapElement(ElementName="subCatId")]
		[XmlElement(ElementName="subCatId")]
		public short gxTpr_Subcatid
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Subcatid; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Subcatid = value;
				SetDirty("Subcatid");
			}
		}


		[SoapElement(ElementName="items")]
		[XmlElement(ElementName="items")]
		public String gxTpr_Items
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Items; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Items = value;
				SetDirty("Items");
			}
		}

		[SoapElement(ElementName="cant")]
		[XmlElement(ElementName="cant")]
		public string gxTpr_Cant_double
		{
			get {
				return Convert.ToString(gxTv_SdtSDTPedidos_SDTPedidosItem_Cant, System.Globalization.CultureInfo.InvariantCulture);
			}
			set {
				gxTv_SdtSDTPedidos_SDTPedidosItem_Cant = (decimal)(Convert.ToDecimal(value, System.Globalization.CultureInfo.InvariantCulture));
			}
		}
		[SoapIgnore]
		[XmlIgnore]
		public decimal gxTpr_Cant
		{
			get { 
				return gxTv_SdtSDTPedidos_SDTPedidosItem_Cant; 
			}
			set { 
				gxTv_SdtSDTPedidos_SDTPedidosItem_Cant = value;
				SetDirty("Cant");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDTPedidos_SDTPedidosItem_Items = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected short gxTv_SdtSDTPedidos_SDTPedidosItem_Nro;
		protected short gxTv_SdtSDTPedidos_SDTPedidosItem_Tipprod;
		protected short gxTv_SdtSDTPedidos_SDTPedidosItem_Catid;
		protected short gxTv_SdtSDTPedidos_SDTPedidosItem_Subcatid;
		protected String gxTv_SdtSDTPedidos_SDTPedidosItem_Items;
		protected decimal gxTv_SdtSDTPedidos_SDTPedidosItem_Cant;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDTPedidosItem", Namespace="KBCalpesa22")]
	public class SdtSDTPedidos_SDTPedidosItem_RESTInterface : GxGenericCollectionItem<SdtSDTPedidos_SDTPedidosItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDTPedidos_SDTPedidosItem_RESTInterface( ) : base()
		{
		}

		public SdtSDTPedidos_SDTPedidosItem_RESTInterface( SdtSDTPedidos_SDTPedidosItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="nro", Order=0)]
		public  Nullable<short> gxTpr_Nro
		{
			get { 
				return sdt.gxTpr_Nro;
			}
			set { 
				sdt.gxTpr_Nro = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="tipProd", Order=1)]
		public  Nullable<short> gxTpr_Tipprod
		{
			get { 
				return sdt.gxTpr_Tipprod;
			}
			set { 
				sdt.gxTpr_Tipprod = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="catId", Order=2)]
		public  Nullable<short> gxTpr_Catid
		{
			get { 
				return sdt.gxTpr_Catid;
			}
			set { 
				sdt.gxTpr_Catid = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="subCatId", Order=3)]
		public  Nullable<short> gxTpr_Subcatid
		{
			get { 
				return sdt.gxTpr_Subcatid;
			}
			set { 
				sdt.gxTpr_Subcatid = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="items", Order=4)]
		public String gxTpr_Items
		{
			get { 
				return sdt.gxTpr_Items;
			}
			set { 
				sdt.gxTpr_Items = value;
			}
		}

		[DataMember(Name="cant", Order=5)]
		public String gxTpr_Cant
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str(  sdt.gxTpr_Cant, 8, 2));
			}
			set { 
				sdt.gxTpr_Cant =  NumberUtil.Val( value, ".");
			}
		}


		#endregion

		public SdtSDTPedidos_SDTPedidosItem sdt
		{
			get { 
				return (SdtSDTPedidos_SDTPedidosItem)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSDTPedidos_SDTPedidosItem() ;
			}
		}
	}
	#endregion
}