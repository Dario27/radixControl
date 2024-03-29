/*
				   File: type_SdtSDT_SweetAlert
			Description: SDT_SweetAlert
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
	[XmlRoot(ElementName="SDT_SweetAlert")]
	[XmlType(TypeName="SDT_SweetAlert" , Namespace="KBCalpesa22" )]
	[Serializable]
	public class SdtSDT_SweetAlert : GxUserType
	{
		public SdtSDT_SweetAlert( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_SweetAlert_Title = "";

			gxTv_SdtSDT_SweetAlert_Type = "";

			gxTv_SdtSDT_SweetAlert_Html = "";

			gxTv_SdtSDT_SweetAlert_Iconcolor = "";

			gxTv_SdtSDT_SweetAlert_Iconhtml = "";

			gxTv_SdtSDT_SweetAlert_Footer = "";

			gxTv_SdtSDT_SweetAlert_Backdrop = "";

			gxTv_SdtSDT_SweetAlert_Toast = "";

			gxTv_SdtSDT_SweetAlert_Grow = "";

			gxTv_SdtSDT_SweetAlert_Width = "";

			gxTv_SdtSDT_SweetAlert_Padding = "";

			gxTv_SdtSDT_SweetAlert_Background = "";

			gxTv_SdtSDT_SweetAlert_Position = "";

			gxTv_SdtSDT_SweetAlert_Confirmbuttontext = "";

			gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor = "";

			gxTv_SdtSDT_SweetAlert_Confirmbuttonurl = "";

			gxTv_SdtSDT_SweetAlert_Cancelbuttontext = "";

			gxTv_SdtSDT_SweetAlert_Cancelbuttonurl = "";

			gxTv_SdtSDT_SweetAlert_Denybuttontext = "";

			gxTv_SdtSDT_SweetAlert_Denyburronurl = "";

			gxTv_SdtSDT_SweetAlert_Imageurl = "";

		}

		public SdtSDT_SweetAlert(IGxContext context)
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
			AddObjectProperty("title", gxTpr_Title, false);
			AddObjectProperty("type", gxTpr_Type, false);
			AddObjectProperty("html", gxTpr_Html, false);
			AddObjectProperty("iconColor", gxTpr_Iconcolor, false);
			AddObjectProperty("iconHtml", gxTpr_Iconhtml, false);
			AddObjectProperty("footer", gxTpr_Footer, false);
			AddObjectProperty("backdrop", gxTpr_Backdrop, false);
			AddObjectProperty("toast", gxTpr_Toast, false);
			AddObjectProperty("grow", gxTpr_Grow, false);
			AddObjectProperty("width", gxTpr_Width, false);
			AddObjectProperty("padding", gxTpr_Padding, false);
			AddObjectProperty("background", gxTpr_Background, false);
			AddObjectProperty("position", gxTpr_Position, false);
			AddObjectProperty("timer", gxTpr_Timer, false);
			AddObjectProperty("showCloseButton", gxTpr_Showclosebutton, false);
			AddObjectProperty("allowEnterKey", gxTpr_Allowenterkey, false);
			AddObjectProperty("allowOutsideClick", gxTpr_Allowoutsideclick, false);
			AddObjectProperty("showConfirmButton", gxTpr_Showconfirmbutton, false);
			AddObjectProperty("confirmButtonText", gxTpr_Confirmbuttontext, false);
			AddObjectProperty("confirmButtonColor", gxTpr_Confirmbuttoncolor, false);
			AddObjectProperty("confirmButtonUrl", gxTpr_Confirmbuttonurl, false);
			AddObjectProperty("focusConfirm", gxTpr_Focusconfirm, false);
			AddObjectProperty("showCancelButton", gxTpr_Showcancelbutton, false);
			AddObjectProperty("cancelButtonText", gxTpr_Cancelbuttontext, false);
			AddObjectProperty("cancelButtonUrl", gxTpr_Cancelbuttonurl, false);
			AddObjectProperty("showDenyButton", gxTpr_Showdenybutton, false);
			AddObjectProperty("denyButtonText", gxTpr_Denybuttontext, false);
			AddObjectProperty("denyBurronUrl", gxTpr_Denyburronurl, false);
			AddObjectProperty("imageUrl", gxTpr_Imageurl, false);
			AddObjectProperty("imageWidth", gxTpr_Imagewidth, false);
			AddObjectProperty("imageHeight", gxTpr_Imageheight, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="title")]
		[XmlElement(ElementName="title")]
		public String gxTpr_Title
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Title; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Title_N = 0;

				gxTv_SdtSDT_SweetAlert_Title = value;
				SetDirty("Title");
			}
		}

		public bool ShouldSerializegxTpr_Title()
		{
			return gxTv_SdtSDT_SweetAlert_Title_N == 0;
		}


		[SoapElement(ElementName="type")]
		[XmlElement(ElementName="type")]
		public String gxTpr_Type
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Type; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Type_N = 0;

				gxTv_SdtSDT_SweetAlert_Type = value;
				SetDirty("Type");
			}
		}

		public bool ShouldSerializegxTpr_Type()
		{
			return gxTv_SdtSDT_SweetAlert_Type_N == 0;
		}


		[SoapElement(ElementName="html")]
		[XmlElement(ElementName="html")]
		public String gxTpr_Html
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Html; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Html_N = 0;

				gxTv_SdtSDT_SweetAlert_Html = value;
				SetDirty("Html");
			}
		}

		public bool ShouldSerializegxTpr_Html()
		{
			return gxTv_SdtSDT_SweetAlert_Html_N == 0;
		}


		[SoapElement(ElementName="iconColor")]
		[XmlElement(ElementName="iconColor")]
		public String gxTpr_Iconcolor
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Iconcolor; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Iconcolor_N = 0;

				gxTv_SdtSDT_SweetAlert_Iconcolor = value;
				SetDirty("Iconcolor");
			}
		}

		public bool ShouldSerializegxTpr_Iconcolor()
		{
			return gxTv_SdtSDT_SweetAlert_Iconcolor_N == 0;
		}


		[SoapElement(ElementName="iconHtml")]
		[XmlElement(ElementName="iconHtml")]
		public String gxTpr_Iconhtml
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Iconhtml; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Iconhtml_N = 0;

				gxTv_SdtSDT_SweetAlert_Iconhtml = value;
				SetDirty("Iconhtml");
			}
		}

		public bool ShouldSerializegxTpr_Iconhtml()
		{
			return gxTv_SdtSDT_SweetAlert_Iconhtml_N == 0;
		}


		[SoapElement(ElementName="footer")]
		[XmlElement(ElementName="footer")]
		public String gxTpr_Footer
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Footer; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Footer_N = 0;

				gxTv_SdtSDT_SweetAlert_Footer = value;
				SetDirty("Footer");
			}
		}

		public bool ShouldSerializegxTpr_Footer()
		{
			return gxTv_SdtSDT_SweetAlert_Footer_N == 0;
		}


		[SoapElement(ElementName="backdrop")]
		[XmlElement(ElementName="backdrop")]
		public String gxTpr_Backdrop
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Backdrop; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Backdrop_N = 0;

				gxTv_SdtSDT_SweetAlert_Backdrop = value;
				SetDirty("Backdrop");
			}
		}

		public bool ShouldSerializegxTpr_Backdrop()
		{
			return gxTv_SdtSDT_SweetAlert_Backdrop_N == 0;
		}


		[SoapElement(ElementName="toast")]
		[XmlElement(ElementName="toast")]
		public String gxTpr_Toast
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Toast; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Toast_N = 0;

				gxTv_SdtSDT_SweetAlert_Toast = value;
				SetDirty("Toast");
			}
		}

		public bool ShouldSerializegxTpr_Toast()
		{
			return gxTv_SdtSDT_SweetAlert_Toast_N == 0;
		}


		[SoapElement(ElementName="grow")]
		[XmlElement(ElementName="grow")]
		public String gxTpr_Grow
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Grow; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Grow_N = 0;

				gxTv_SdtSDT_SweetAlert_Grow = value;
				SetDirty("Grow");
			}
		}

		public bool ShouldSerializegxTpr_Grow()
		{
			return gxTv_SdtSDT_SweetAlert_Grow_N == 0;
		}


		[SoapElement(ElementName="width")]
		[XmlElement(ElementName="width")]
		public String gxTpr_Width
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Width; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Width_N = 0;

				gxTv_SdtSDT_SweetAlert_Width = value;
				SetDirty("Width");
			}
		}

		public bool ShouldSerializegxTpr_Width()
		{
			return gxTv_SdtSDT_SweetAlert_Width_N == 0;
		}


		[SoapElement(ElementName="padding")]
		[XmlElement(ElementName="padding")]
		public String gxTpr_Padding
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Padding; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Padding_N = 0;

				gxTv_SdtSDT_SweetAlert_Padding = value;
				SetDirty("Padding");
			}
		}

		public bool ShouldSerializegxTpr_Padding()
		{
			return gxTv_SdtSDT_SweetAlert_Padding_N == 0;
		}


		[SoapElement(ElementName="background")]
		[XmlElement(ElementName="background")]
		public String gxTpr_Background
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Background; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Background_N = 0;

				gxTv_SdtSDT_SweetAlert_Background = value;
				SetDirty("Background");
			}
		}

		public bool ShouldSerializegxTpr_Background()
		{
			return gxTv_SdtSDT_SweetAlert_Background_N == 0;
		}


		[SoapElement(ElementName="position")]
		[XmlElement(ElementName="position")]
		public String gxTpr_Position
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Position; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Position_N = 0;

				gxTv_SdtSDT_SweetAlert_Position = value;
				SetDirty("Position");
			}
		}

		public bool ShouldSerializegxTpr_Position()
		{
			return gxTv_SdtSDT_SweetAlert_Position_N == 0;
		}


		[SoapElement(ElementName="timer")]
		[XmlElement(ElementName="timer")]
		public short gxTpr_Timer
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Timer; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Timer_N = 0;

				gxTv_SdtSDT_SweetAlert_Timer = value;
				SetDirty("Timer");
			}
		}

		public bool ShouldSerializegxTpr_Timer()
		{
			return gxTv_SdtSDT_SweetAlert_Timer_N == 0;
		}


		[SoapElement(ElementName="showCloseButton")]
		[XmlElement(ElementName="showCloseButton")]
		public bool gxTpr_Showclosebutton
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Showclosebutton; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Showclosebutton_N = 0;

				gxTv_SdtSDT_SweetAlert_Showclosebutton = value;
				SetDirty("Showclosebutton");
			}
		}

		public bool ShouldSerializegxTpr_Showclosebutton()
		{
			return gxTv_SdtSDT_SweetAlert_Showclosebutton_N == 0;
		}


		[SoapElement(ElementName="allowEnterKey")]
		[XmlElement(ElementName="allowEnterKey")]
		public bool gxTpr_Allowenterkey
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Allowenterkey; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Allowenterkey_N = 0;

				gxTv_SdtSDT_SweetAlert_Allowenterkey = value;
				SetDirty("Allowenterkey");
			}
		}

		public bool ShouldSerializegxTpr_Allowenterkey()
		{
			return gxTv_SdtSDT_SweetAlert_Allowenterkey_N == 0;
		}


		[SoapElement(ElementName="allowOutsideClick")]
		[XmlElement(ElementName="allowOutsideClick")]
		public bool gxTpr_Allowoutsideclick
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Allowoutsideclick; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Allowoutsideclick_N = 0;

				gxTv_SdtSDT_SweetAlert_Allowoutsideclick = value;
				SetDirty("Allowoutsideclick");
			}
		}

		public bool ShouldSerializegxTpr_Allowoutsideclick()
		{
			return gxTv_SdtSDT_SweetAlert_Allowoutsideclick_N == 0;
		}


		[SoapElement(ElementName="showConfirmButton")]
		[XmlElement(ElementName="showConfirmButton")]
		public bool gxTpr_Showconfirmbutton
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Showconfirmbutton; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Showconfirmbutton = value;
				SetDirty("Showconfirmbutton");
			}
		}


		[SoapElement(ElementName="confirmButtonText")]
		[XmlElement(ElementName="confirmButtonText")]
		public String gxTpr_Confirmbuttontext
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Confirmbuttontext; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Confirmbuttontext_N = 0;

				gxTv_SdtSDT_SweetAlert_Confirmbuttontext = value;
				SetDirty("Confirmbuttontext");
			}
		}

		public bool ShouldSerializegxTpr_Confirmbuttontext()
		{
			return gxTv_SdtSDT_SweetAlert_Confirmbuttontext_N == 0;
		}


		[SoapElement(ElementName="confirmButtonColor")]
		[XmlElement(ElementName="confirmButtonColor")]
		public String gxTpr_Confirmbuttoncolor
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor_N = 0;

				gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor = value;
				SetDirty("Confirmbuttoncolor");
			}
		}

		public bool ShouldSerializegxTpr_Confirmbuttoncolor()
		{
			return gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor_N == 0;
		}


		[SoapElement(ElementName="confirmButtonUrl")]
		[XmlElement(ElementName="confirmButtonUrl")]
		public String gxTpr_Confirmbuttonurl
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Confirmbuttonurl; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Confirmbuttonurl = value;
				SetDirty("Confirmbuttonurl");
			}
		}


		[SoapElement(ElementName="focusConfirm")]
		[XmlElement(ElementName="focusConfirm")]
		public bool gxTpr_Focusconfirm
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Focusconfirm; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Focusconfirm_N = 0;

				gxTv_SdtSDT_SweetAlert_Focusconfirm = value;
				SetDirty("Focusconfirm");
			}
		}

		public bool ShouldSerializegxTpr_Focusconfirm()
		{
			return gxTv_SdtSDT_SweetAlert_Focusconfirm_N == 0;
		}


		[SoapElement(ElementName="showCancelButton")]
		[XmlElement(ElementName="showCancelButton")]
		public bool gxTpr_Showcancelbutton
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Showcancelbutton; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Showcancelbutton = value;
				SetDirty("Showcancelbutton");
			}
		}


		[SoapElement(ElementName="cancelButtonText")]
		[XmlElement(ElementName="cancelButtonText")]
		public String gxTpr_Cancelbuttontext
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Cancelbuttontext; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Cancelbuttontext = value;
				SetDirty("Cancelbuttontext");
			}
		}


		[SoapElement(ElementName="cancelButtonUrl")]
		[XmlElement(ElementName="cancelButtonUrl")]
		public String gxTpr_Cancelbuttonurl
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Cancelbuttonurl; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Cancelbuttonurl = value;
				SetDirty("Cancelbuttonurl");
			}
		}


		[SoapElement(ElementName="showDenyButton")]
		[XmlElement(ElementName="showDenyButton")]
		public bool gxTpr_Showdenybutton
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Showdenybutton; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Showdenybutton = value;
				SetDirty("Showdenybutton");
			}
		}


		[SoapElement(ElementName="denyButtonText")]
		[XmlElement(ElementName="denyButtonText")]
		public String gxTpr_Denybuttontext
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Denybuttontext; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Denybuttontext = value;
				SetDirty("Denybuttontext");
			}
		}


		[SoapElement(ElementName="denyBurronUrl")]
		[XmlElement(ElementName="denyBurronUrl")]
		public String gxTpr_Denyburronurl
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Denyburronurl; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Denyburronurl = value;
				SetDirty("Denyburronurl");
			}
		}


		[SoapElement(ElementName="imageUrl")]
		[XmlElement(ElementName="imageUrl")]
		public String gxTpr_Imageurl
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Imageurl; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Imageurl = value;
				SetDirty("Imageurl");
			}
		}


		[SoapElement(ElementName="imageWidth")]
		[XmlElement(ElementName="imageWidth")]
		public short gxTpr_Imagewidth
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Imagewidth; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Imagewidth = value;
				SetDirty("Imagewidth");
			}
		}


		[SoapElement(ElementName="imageHeight")]
		[XmlElement(ElementName="imageHeight")]
		public short gxTpr_Imageheight
		{
			get { 
				return gxTv_SdtSDT_SweetAlert_Imageheight; 
			}
			set { 
				gxTv_SdtSDT_SweetAlert_Imageheight = value;
				SetDirty("Imageheight");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_SweetAlert_Title = "";
				gxTv_SdtSDT_SweetAlert_Title_N = 1;

			gxTv_SdtSDT_SweetAlert_Type = "";
				gxTv_SdtSDT_SweetAlert_Type_N = 1;

			gxTv_SdtSDT_SweetAlert_Html = "";
				gxTv_SdtSDT_SweetAlert_Html_N = 1;

			gxTv_SdtSDT_SweetAlert_Iconcolor = "";
				gxTv_SdtSDT_SweetAlert_Iconcolor_N = 1;

			gxTv_SdtSDT_SweetAlert_Iconhtml = "";
				gxTv_SdtSDT_SweetAlert_Iconhtml_N = 1;

			gxTv_SdtSDT_SweetAlert_Footer = "";
				gxTv_SdtSDT_SweetAlert_Footer_N = 1;

			gxTv_SdtSDT_SweetAlert_Backdrop = "";
				gxTv_SdtSDT_SweetAlert_Backdrop_N = 1;

			gxTv_SdtSDT_SweetAlert_Toast = "";
				gxTv_SdtSDT_SweetAlert_Toast_N = 1;

			gxTv_SdtSDT_SweetAlert_Grow = "";
				gxTv_SdtSDT_SweetAlert_Grow_N = 1;

			gxTv_SdtSDT_SweetAlert_Width = "";
				gxTv_SdtSDT_SweetAlert_Width_N = 1;

			gxTv_SdtSDT_SweetAlert_Padding = "";
				gxTv_SdtSDT_SweetAlert_Padding_N = 1;

			gxTv_SdtSDT_SweetAlert_Background = "";
				gxTv_SdtSDT_SweetAlert_Background_N = 1;

			gxTv_SdtSDT_SweetAlert_Position = "";
				gxTv_SdtSDT_SweetAlert_Position_N = 1;


				gxTv_SdtSDT_SweetAlert_Timer_N = 1;


				gxTv_SdtSDT_SweetAlert_Showclosebutton_N = 1;


				gxTv_SdtSDT_SweetAlert_Allowenterkey_N = 1;


				gxTv_SdtSDT_SweetAlert_Allowoutsideclick_N = 1;


			gxTv_SdtSDT_SweetAlert_Confirmbuttontext = "";
				gxTv_SdtSDT_SweetAlert_Confirmbuttontext_N = 1;

			gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor = "";
				gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor_N = 1;

			gxTv_SdtSDT_SweetAlert_Confirmbuttonurl = "";

				gxTv_SdtSDT_SweetAlert_Focusconfirm_N = 1;


			gxTv_SdtSDT_SweetAlert_Cancelbuttontext = "";
			gxTv_SdtSDT_SweetAlert_Cancelbuttonurl = "";

			gxTv_SdtSDT_SweetAlert_Denybuttontext = "";
			gxTv_SdtSDT_SweetAlert_Denyburronurl = "";
			gxTv_SdtSDT_SweetAlert_Imageurl = "";


			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_SweetAlert_Title;
		protected short gxTv_SdtSDT_SweetAlert_Title_N;
		protected String gxTv_SdtSDT_SweetAlert_Type;
		protected short gxTv_SdtSDT_SweetAlert_Type_N;
		protected String gxTv_SdtSDT_SweetAlert_Html;
		protected short gxTv_SdtSDT_SweetAlert_Html_N;
		protected String gxTv_SdtSDT_SweetAlert_Iconcolor;
		protected short gxTv_SdtSDT_SweetAlert_Iconcolor_N;
		protected String gxTv_SdtSDT_SweetAlert_Iconhtml;
		protected short gxTv_SdtSDT_SweetAlert_Iconhtml_N;
		protected String gxTv_SdtSDT_SweetAlert_Footer;
		protected short gxTv_SdtSDT_SweetAlert_Footer_N;
		protected String gxTv_SdtSDT_SweetAlert_Backdrop;
		protected short gxTv_SdtSDT_SweetAlert_Backdrop_N;
		protected String gxTv_SdtSDT_SweetAlert_Toast;
		protected short gxTv_SdtSDT_SweetAlert_Toast_N;
		protected String gxTv_SdtSDT_SweetAlert_Grow;
		protected short gxTv_SdtSDT_SweetAlert_Grow_N;
		protected String gxTv_SdtSDT_SweetAlert_Width;
		protected short gxTv_SdtSDT_SweetAlert_Width_N;
		protected String gxTv_SdtSDT_SweetAlert_Padding;
		protected short gxTv_SdtSDT_SweetAlert_Padding_N;
		protected String gxTv_SdtSDT_SweetAlert_Background;
		protected short gxTv_SdtSDT_SweetAlert_Background_N;
		protected String gxTv_SdtSDT_SweetAlert_Position;
		protected short gxTv_SdtSDT_SweetAlert_Position_N;
		protected short gxTv_SdtSDT_SweetAlert_Timer;
		protected short gxTv_SdtSDT_SweetAlert_Timer_N;
		protected bool gxTv_SdtSDT_SweetAlert_Showclosebutton;
		protected short gxTv_SdtSDT_SweetAlert_Showclosebutton_N;
		protected bool gxTv_SdtSDT_SweetAlert_Allowenterkey;
		protected short gxTv_SdtSDT_SweetAlert_Allowenterkey_N;
		protected bool gxTv_SdtSDT_SweetAlert_Allowoutsideclick;
		protected short gxTv_SdtSDT_SweetAlert_Allowoutsideclick_N;
		protected bool gxTv_SdtSDT_SweetAlert_Showconfirmbutton;
		protected String gxTv_SdtSDT_SweetAlert_Confirmbuttontext;
		protected short gxTv_SdtSDT_SweetAlert_Confirmbuttontext_N;
		protected String gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor;
		protected short gxTv_SdtSDT_SweetAlert_Confirmbuttoncolor_N;
		protected String gxTv_SdtSDT_SweetAlert_Confirmbuttonurl;
		protected bool gxTv_SdtSDT_SweetAlert_Focusconfirm;
		protected short gxTv_SdtSDT_SweetAlert_Focusconfirm_N;
		protected bool gxTv_SdtSDT_SweetAlert_Showcancelbutton;
		protected String gxTv_SdtSDT_SweetAlert_Cancelbuttontext;
		protected String gxTv_SdtSDT_SweetAlert_Cancelbuttonurl;
		protected bool gxTv_SdtSDT_SweetAlert_Showdenybutton;
		protected String gxTv_SdtSDT_SweetAlert_Denybuttontext;
		protected String gxTv_SdtSDT_SweetAlert_Denyburronurl;
		protected String gxTv_SdtSDT_SweetAlert_Imageurl;
		protected short gxTv_SdtSDT_SweetAlert_Imagewidth;
		protected short gxTv_SdtSDT_SweetAlert_Imageheight;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_SweetAlert", Namespace="KBCalpesa22")]
	public class SdtSDT_SweetAlert_RESTInterface : GxGenericCollectionItem<SdtSDT_SweetAlert>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_SweetAlert_RESTInterface( ) : base()
		{
		}

		public SdtSDT_SweetAlert_RESTInterface( SdtSDT_SweetAlert psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="title", Order=0)]
		public String gxTpr_Title
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Title);
			}
			set { 
				sdt.gxTpr_Title = value;
			}
		}

		[DataMember(Name="type", Order=1)]
		public String gxTpr_Type
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Type);
			}
			set { 
				sdt.gxTpr_Type = value;
			}
		}

		[DataMember(Name="html", Order=2)]
		public String gxTpr_Html
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Html);
			}
			set { 
				sdt.gxTpr_Html = value;
			}
		}

		[DataMember(Name="iconColor", Order=3)]
		public String gxTpr_Iconcolor
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Iconcolor);
			}
			set { 
				sdt.gxTpr_Iconcolor = value;
			}
		}

		[DataMember(Name="iconHtml", Order=4)]
		public String gxTpr_Iconhtml
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Iconhtml);
			}
			set { 
				sdt.gxTpr_Iconhtml = value;
			}
		}

		[DataMember(Name="footer", Order=5)]
		public String gxTpr_Footer
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Footer);
			}
			set { 
				sdt.gxTpr_Footer = value;
			}
		}

		[DataMember(Name="backdrop", Order=6)]
		public String gxTpr_Backdrop
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Backdrop);
			}
			set { 
				sdt.gxTpr_Backdrop = value;
			}
		}

		[DataMember(Name="toast", Order=7)]
		public String gxTpr_Toast
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Toast);
			}
			set { 
				sdt.gxTpr_Toast = value;
			}
		}

		[DataMember(Name="grow", Order=8)]
		public String gxTpr_Grow
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Grow);
			}
			set { 
				sdt.gxTpr_Grow = value;
			}
		}

		[DataMember(Name="width", Order=9)]
		public String gxTpr_Width
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Width);
			}
			set { 
				sdt.gxTpr_Width = value;
			}
		}

		[DataMember(Name="padding", Order=10)]
		public String gxTpr_Padding
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Padding);
			}
			set { 
				sdt.gxTpr_Padding = value;
			}
		}

		[DataMember(Name="background", Order=11)]
		public String gxTpr_Background
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Background);
			}
			set { 
				sdt.gxTpr_Background = value;
			}
		}

		[DataMember(Name="position", Order=12)]
		public String gxTpr_Position
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Position);
			}
			set { 
				sdt.gxTpr_Position = value;
			}
		}

		[DataMember(Name="timer", Order=13)]
		public  Nullable<short> gxTpr_Timer
		{
			get { 
				return sdt.gxTpr_Timer;
			}
			set { 
				sdt.gxTpr_Timer = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="showCloseButton", Order=14)]
		public bool gxTpr_Showclosebutton
		{
			get { 
				return sdt.gxTpr_Showclosebutton;
			}
			set { 
				sdt.gxTpr_Showclosebutton = value;
			}
		}

		[DataMember(Name="allowEnterKey", Order=15)]
		public bool gxTpr_Allowenterkey
		{
			get { 
				return sdt.gxTpr_Allowenterkey;
			}
			set { 
				sdt.gxTpr_Allowenterkey = value;
			}
		}

		[DataMember(Name="allowOutsideClick", Order=16)]
		public bool gxTpr_Allowoutsideclick
		{
			get { 
				return sdt.gxTpr_Allowoutsideclick;
			}
			set { 
				sdt.gxTpr_Allowoutsideclick = value;
			}
		}

		[DataMember(Name="showConfirmButton", Order=17)]
		public bool gxTpr_Showconfirmbutton
		{
			get { 
				return sdt.gxTpr_Showconfirmbutton;
			}
			set { 
				sdt.gxTpr_Showconfirmbutton = value;
			}
		}

		[DataMember(Name="confirmButtonText", Order=18)]
		public String gxTpr_Confirmbuttontext
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Confirmbuttontext);
			}
			set { 
				sdt.gxTpr_Confirmbuttontext = value;
			}
		}

		[DataMember(Name="confirmButtonColor", Order=19)]
		public String gxTpr_Confirmbuttoncolor
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Confirmbuttoncolor);
			}
			set { 
				sdt.gxTpr_Confirmbuttoncolor = value;
			}
		}

		[DataMember(Name="confirmButtonUrl", Order=20)]
		public String gxTpr_Confirmbuttonurl
		{
			get { 
				return sdt.gxTpr_Confirmbuttonurl;
			}
			set { 
				sdt.gxTpr_Confirmbuttonurl = value;
			}
		}

		[DataMember(Name="focusConfirm", Order=21)]
		public bool gxTpr_Focusconfirm
		{
			get { 
				return sdt.gxTpr_Focusconfirm;
			}
			set { 
				sdt.gxTpr_Focusconfirm = value;
			}
		}

		[DataMember(Name="showCancelButton", Order=22)]
		public bool gxTpr_Showcancelbutton
		{
			get { 
				return sdt.gxTpr_Showcancelbutton;
			}
			set { 
				sdt.gxTpr_Showcancelbutton = value;
			}
		}

		[DataMember(Name="cancelButtonText", Order=23)]
		public String gxTpr_Cancelbuttontext
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Cancelbuttontext);
			}
			set { 
				sdt.gxTpr_Cancelbuttontext = value;
			}
		}

		[DataMember(Name="cancelButtonUrl", Order=24)]
		public String gxTpr_Cancelbuttonurl
		{
			get { 
				return sdt.gxTpr_Cancelbuttonurl;
			}
			set { 
				sdt.gxTpr_Cancelbuttonurl = value;
			}
		}

		[DataMember(Name="showDenyButton", Order=25)]
		public bool gxTpr_Showdenybutton
		{
			get { 
				return sdt.gxTpr_Showdenybutton;
			}
			set { 
				sdt.gxTpr_Showdenybutton = value;
			}
		}

		[DataMember(Name="denyButtonText", Order=26)]
		public String gxTpr_Denybuttontext
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Denybuttontext);
			}
			set { 
				sdt.gxTpr_Denybuttontext = value;
			}
		}

		[DataMember(Name="denyBurronUrl", Order=27)]
		public String gxTpr_Denyburronurl
		{
			get { 
				return sdt.gxTpr_Denyburronurl;
			}
			set { 
				sdt.gxTpr_Denyburronurl = value;
			}
		}

		[DataMember(Name="imageUrl", Order=28)]
		public String gxTpr_Imageurl
		{
			get { 
				return sdt.gxTpr_Imageurl;
			}
			set { 
				sdt.gxTpr_Imageurl = value;
			}
		}

		[DataMember(Name="imageWidth", Order=29)]
		public  Nullable<short> gxTpr_Imagewidth
		{
			get { 
				return sdt.gxTpr_Imagewidth;
			}
			set { 
				sdt.gxTpr_Imagewidth = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="imageHeight", Order=30)]
		public  Nullable<short> gxTpr_Imageheight
		{
			get { 
				return sdt.gxTpr_Imageheight;
			}
			set { 
				sdt.gxTpr_Imageheight = (short) (value.HasValue ? value.Value : 0);
			}
		}


		#endregion

		public SdtSDT_SweetAlert sdt
		{
			get { 
				return (SdtSDT_SweetAlert)Sdt;
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
				sdt = new SdtSDT_SweetAlert() ;
			}
		}
	}
	#endregion
}